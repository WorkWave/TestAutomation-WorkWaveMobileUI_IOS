using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class ServicesSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        ServiceView serviceView = new ServiceView();
        OrderPageView orderPageView = new OrderPageView();
        double subTotal,total,productTotalAmount, updatedSubTotal, updatedTotal, expectedServiceTotal, expectedServiceSubTotal,servicePrice,updatedServiceAmount,discountAmount,serviceAmountBefore,productAmount, updatedProductSubTotal,productSubTotal,updatedProductAmount = 0.00;
        string productTotal,firstProductValue, serviceDescription,serviceValueAmount,servicePriceString = null;

        public ServicesSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [Given("Any Services Exist On Order")]
        public void GivenServicesExist(Table data)
        {           
            common.GivenNotStartedOrderOpened(data);
            WorkwaveMobileSupport.SwipeDownIOS("FORMS");
            WorkwaveData.Services = data.CreateInstance<Payment>();
            common.WorkOrderDiscountsRemoved();
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
        }

        [When("Discount Tab Opened")]
        public void WhenDiscountTabOpened()
        {
            serviceView = new ServiceView();

            Assert.True(serviceView.VerifyViewLoadedByText(5, "Start"));
            serviceView.ClickOnDiscount();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Work Order Discounts"));
        }

      

        [When(@"Navigate To Services View")]
        public void WhenNavigateToServicesView()
        {
            //WorkwaveMobileSupport.SwipeDownIOS("SERVICES");
            //while (!serviceView.VerifyServicesViewLoaded(5))
            //{
            //    WorkwaveMobileSupport.SwipeUpIOS("SERVICES");
            //    if (!serviceView.VerifyServicesViewLoaded(5))
            //    {
            //        WorkwaveMobileSupport.SwipeDownIOS("SERVICES");
            //    }
            //}
            //WorkwaveMobileSupport.Swipe(-1);
            serviceView.ViewServices();
        }


        [Given(@"Product Tab Opened")]
        public void GivenProductTabOpened(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickProductButton();
        }
        
        [When(@"Product Added")]
        public void WhenProductAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickAddIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Product"));
            serviceView.EnterTextOnCommonField(WorkwaveData.Services.ServiceProduct);
            serviceView.ClickOnStaticText(WorkwaveData.Services.ServiceProduct);

            Assert.True(serviceView.VerifyViewLoadedByHeader(5,"Add "+ WorkwaveData.Services.ServiceProduct));
            WorkwaveData.Services.ServiceProductQuantity = WorkwaveMobileSupport.RandomInt(3);
            double quantity = double.Parse(WorkwaveData.Services.ServiceProductQuantity);
            String ProductPrice = serviceView.getPrice();
            double price = double.Parse(ProductPrice);
            serviceView.EnterProductQuantity(WorkwaveData.Services.ServiceProductQuantity);

            productTotal = serviceView.GetProductSubTotal();
            productTotalAmount = serviceView.GetProSubTotalValue();
            Console.WriteLine(productTotalAmount);
            double expectedquan = quantity * price;
            Console.WriteLine(expectedquan);
            Assert.True(productTotalAmount == expectedquan);

            WorkwaveData.Services.ServiceProductPrice = productTotal;
            serviceView.ClickOnStaticText("Add");

            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            expectedServiceSubTotal = productTotalAmount + subTotal;
            expectedServiceTotal = productTotalAmount + total;

        }
        
        [Then(@"Verify Product Exists")]
        public void ThenVerifyProductExists()
        {
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceProduct));
            Assert.True(serviceView.VerifyViewLoadedByText(5,"$"+ productTotal));
        }
        
        [Then(@"Verify Service Total")]
        public void ThenVerifyServiceTotal()
        {
            serviceView.ClickBack();
            Assert.True(serviceView.VerifyViewLoadedByText(5, "Start"));
             updatedSubTotal = serviceView.GetSubTotal();
             updatedTotal = serviceView.GetTotal();
            Console.WriteLine(updatedSubTotal);
            Console.WriteLine(expectedServiceSubTotal);
            Assert.True(updatedSubTotal.Equals(expectedServiceSubTotal));
            Assert.True(updatedTotal.Equals(expectedServiceTotal));
        }

        [When(@"Product Edited")]
        public void WhenProductEdited(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();

            //Get the existing price before update
            double prodVal = serviceView.GetproductValue();

            serviceView.ClickOnLastStaticText(WorkwaveData.Services.ServiceProduct);

            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Edit " + WorkwaveData.Services.ServiceProduct));
            WorkwaveData.Services.ServiceProductQuantity = WorkwaveMobileSupport.RandomInt(3);
            WorkwaveData.Services.ServiceProductPrice = serviceView.getPrice();
            serviceView.EnterProductQuantity(WorkwaveData.Services.ServiceProductQuantity);

            productTotal = serviceView.GetProductSubTotal();
            double productTotalAmountUpdated = serviceView.GetProSubTotalValue();
            Console.WriteLine("productTotalAmountUpdated " + productTotalAmountUpdated);
            double expectedquan = (Double.Parse(WorkwaveData.Services.ServiceProductQuantity) * Double.Parse(WorkwaveData.Services.ServiceProductPrice));
            Console.WriteLine(expectedquan);
            Assert.True(productTotalAmountUpdated == expectedquan);

            WorkwaveData.Services.ServiceProductPrice = productTotal;
            serviceView.ClickOnStaticText("Save");

            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));

            expectedServiceSubTotal = (updatedSubTotal - prodVal)  + productTotalAmountUpdated;

            Console.WriteLine("expectedServiceSubTotal "+expectedServiceSubTotal);
            expectedServiceTotal = (updatedTotal - prodVal) + productTotalAmountUpdated ;
        }

        [When(@"Product Deleted")]
        public void WhenProductDeleted(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();

            double existingProdSubTotal = serviceView.GetProMainSubTotalValue();
            firstProductValue = serviceView.getFirstProPrice(WorkwaveData.Services.ServiceProduct);
            double prodVal = serviceView.GetFirstproductValue(WorkwaveData.Services.ServiceProduct);
            serviceView.DeleteProductMaterial(WorkwaveData.Services.ServiceProduct);
            serviceView.ClickOnText("Delete");
            double productTotalAmountUpdated = serviceView.GetProMainSubTotalValue();
            Console.WriteLine("productTotalAmountUpdated " + productTotalAmountUpdated);
            double expectedquan = existingProdSubTotal - prodVal;
            Console.WriteLine(expectedquan);
            Assert.True(productTotalAmountUpdated == expectedquan);

            expectedServiceSubTotal = updatedSubTotal - prodVal;

            Console.WriteLine("expectedServiceSubTotal " + expectedServiceSubTotal);
            expectedServiceTotal = updatedTotal - prodVal;
        }

        [Then(@"Verify Product Deleted")]
        public void ThenVerifyProductDeleted()
        {
            Assert.True(serviceView.findElement(firstProductValue) == null);

        }

        [Given(@"Material Tab Opened")]
        public void GivenMaterialTabOpened(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickMaterialButton();
        }

        [When(@"Material Added")]
        public void WhenMaterialAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickAddIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Material"));
            serviceView.EnterTextOnCommonField(WorkwaveData.Services.ServiceMaterial);
            serviceView.ClickOnStaticText(WorkwaveData.Services.ServiceMaterial);

            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add "+ WorkwaveData.Services.ServiceMaterial));
            WorkwaveData.Services.ServiceMaterialQuantity = WorkwaveMobileSupport.RandomInt(5);
            serviceView.EnterMaterialQuantity(WorkwaveData.Services.ServiceMaterialQuantity);

            serviceView.ClickOnStaticText("Add");

        }

        [Then(@"Verify Material Exists")]
        public void ThenVerifyMaterialExists()
        {
            //serviceView.ClickBack();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceMaterial));
        }

        [When(@"Material Edited")]
        public void WhenMaterialEdited(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickOnStaticText(WorkwaveData.Services.ServiceMaterial);
            WorkwaveData.Services.ServiceMaterialQuantity = WorkwaveMobileSupport.RandomInt(5);
            serviceView.EnterMaterialQuantity(WorkwaveData.Services.ServiceMaterialQuantity);
            serviceView.ClickOnStaticText("Save");

        }

        [Then(@"Verify Material Edited")]
        public void ThenVerifyMaterialEdited()
        {
            serviceView.ClickOnStaticText(WorkwaveData.Services.ServiceMaterial);
            string updatedQuantity = serviceView.getMaterialQuantity();
            Console.WriteLine(updatedQuantity);
            Console.WriteLine(WorkwaveData.Services.ServiceMaterialQuantity);
            Assert.True(updatedQuantity .Equals(WorkwaveData.Services.ServiceMaterialQuantity));

        }

        [When(@"Material Deleted")]
        public void WhenMaterialDeleted(Table data)
        {
            serviceView.ClickBack();
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.DeleteProductMaterial(WorkwaveData.Services.ServiceMaterial);
            System.TimeSpan.FromSeconds(60);
            serviceView.ClickOnStaticText("Delete");
        }

        [Then(@"Verify Material Does Not Exist")]
        public void ThenVerifyMaterialDoesNotExist()
        {
            Assert.True(serviceView.findElement(WorkwaveData.Services.ServiceMaterial) == null);
        }

        [Given("Discount Tab Opened")]
        public void GivenDiscountTabOpened(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
            servicePrice = serviceView.GetServiceAmount(WorkwaveData.Services.ServiceType);
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickProductButton();
            double productTotalAmountUpdated = serviceView.GetProMainSubTotalValue();
            updatedServiceAmount = servicePrice - productTotalAmountUpdated;
            serviceView.ClickDiscountButton();
            serviceView.ClickAddIcon();
        }

        [When(@"Discount Added")]
        public void WhenDiscountAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
           
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Discount"));
            WorkwaveData.Services.ServiceDiscountDescription = WorkwaveMobileSupport.generateRandomString(10);
            serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountDescription,"Description");
           
            WorkwaveData.Services.ServiceDiscountAmount = WorkwaveMobileSupport.RandomInt(2);
            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {
               
                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Percentage");
            }
            else
            {
                serviceView.ClickOnButton(WorkwaveData.Services.ServiceDiscountType);
                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Amount");
            }

            serviceView.ClickOnStaticText("Add");
            double discount = double.Parse(WorkwaveData.Services.ServiceDiscountAmount);

            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {
                discountAmount = (updatedServiceAmount * discount) / 100;
                expectedServiceSubTotal = subTotal - ((updatedServiceAmount * discount) / 100);
                expectedServiceTotal = total - ((updatedServiceAmount * discount) / 100);
            }
            else
            {
                discountAmount = discount;
                expectedServiceSubTotal = subTotal - discount;
                expectedServiceTotal = total - discount;
            }

            serviceDescription = WorkwaveData.Services.ServiceDiscountDescription;

            serviceAmountBefore = updatedServiceAmount;
        }

        [Then(@"Verify Discount Exists")]
        public void ThenVerifyDiscountExists()
        {
            Assert.True(serviceView.VerifyViewLoadedByText(5, serviceDescription));
        }

        [Then(@"Verify Discount Applied")]
        public void ThenVerifyDiscountApplied()
        {
            ThenVerifyServiceTotal();
        }

        [When(@"Discount Edited")]
        public void WhenDiscountEdited(Table data)
        {
            
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickBack();
            serviceView.ClickOnText(serviceDescription);
            //WorkwaveData.Services.ServiceDiscountDescription = WorkwaveMobileSupport.generateRandomString(10);
            //serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountDescription, "Description");
            
            WorkwaveData.Services.ServiceDiscountAmount = WorkwaveMobileSupport.RandomInt(2);
            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {

                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Percentage");
            }
            else
            {
                serviceView.ClickOnButton(WorkwaveData.Services.ServiceDiscountType);
                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Amount");
            }

            serviceView.ClickOnStaticText("Add");
            double discount = double.Parse(WorkwaveData.Services.ServiceDiscountAmount);

            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {
                expectedServiceSubTotal = (subTotal - ((serviceAmountBefore * discount) / 100))+ discountAmount;
                expectedServiceTotal = (total - ((serviceAmountBefore * discount) / 100))+ discountAmount;
                discountAmount = (serviceAmountBefore * discount) / 100;
            }
            else
            {
                expectedServiceSubTotal = (subTotal - discount)+ discountAmount;
                expectedServiceTotal = (total - discount)+ discountAmount;
                discountAmount = discount;
            }

            //serviceDescription = WorkwaveData.Services.ServiceDiscountDescription;
        }

        [When(@"Discount Deleted")]
        public void WhenDiscountDeleted(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickMainBackButtonTwo();
            serviceView.ClickOnText(serviceDescription);
            serviceView.ClickOnText("Remove Discount");

            expectedServiceSubTotal = subTotal  + discountAmount;
            expectedServiceTotal = total + discountAmount;

        }

        [When(@"Delete Product Value Discount")]
        public void WhenDeleteProductValueDiscount(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickOnText(serviceDescription);
            serviceView.ClickOnText("Remove Discount");
            expectedServiceSubTotal = subTotal + discountAmount;
            expectedServiceTotal = total + discountAmount;

        }


        [When(@"Delete Service Offering Percentage")]
        public void WhenDeleteServiceOfferingPercentage(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickBack();
            serviceView.ClickOnText(serviceDescription);
            serviceView.ClickOnText("Remove Discount");
            expectedServiceSubTotal = subTotal + discountAmount;
            expectedServiceTotal = total + discountAmount;
        }


        [When(@"Delete Product Percentage Discount")]
        public void WhenDeleteProductPercentageDiscount(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickOnText(serviceDescription);
            serviceView.ClickOnText("Remove Discount");
            expectedServiceSubTotal = subTotal + discountAmount;
            expectedServiceTotal = total + discountAmount;
        }


        [Then(@"Verify Discount Does Not Exist")]
        public void ThenVerifyDiscountDoesNotExist()
        {
            Assert.True(serviceView.findDiscount(WorkwaveData.Services.ServiceDiscountDescription) == null);
        }

        [Then(@"Verify Discount Removed")]
        public void ThenVerifyDiscountRemoved()
        {
            ThenVerifyServiceTotal();
        }

        [When(@"Service Added")]
        public void WhenServiceAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickPlusIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add"));
            serviceView.ClickOnStaticText("Services");
            System.TimeSpan.FromSeconds(60);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Service"));
            serviceView.EnterTextOnCommonField(WorkwaveData.Services.ServiceType);
            serviceView.ClickOnText(WorkwaveData.Services.ServiceType);
            serviceView.ClickOnStaticText("Add");
        }

        [Then(@"Verify Service Added")]
        public void ThenVerifyServiceAdded()
        {
           
            Assert.True(serviceView.VerifyViewLoadedByText(5, WorkwaveData.Services.ServiceType));
        }

        [When(@"Service Edited")]
        public void WhenServiceEdited(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickOnText(WorkwaveData.Services.ServiceType);
            if (serviceView.VerifyViewLoaded(5, WorkwaveData.Services.ServiceType))
            {
                System.TimeSpan.FromSeconds(30);
            }
            serviceValueAmount = serviceView.getServicePriceString(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            WorkwaveData.Services.ServicePrice = WorkwaveMobileSupport.RandomInt(4);
            serviceView.EnterServicePrice(WorkwaveData.Services.ServicePrice);
            serviceView.ClickOnText("Save");
        }

        [Then(@"Verify Service Edited")]
        public void ThenVerifyServiceEdited()
        {
            string updatedSerPrice = serviceView.GetservicePrice();
            Assert.True(updatedSerPrice.Equals(WorkwaveData.Services.ServicePrice));
            serviceView.ClickBack();
            string updatedAmount = serviceView.getServicePriceString(WorkwaveData.Services.ServiceType);
            Assert.True(!updatedAmount.Equals(serviceValueAmount));
        }

        [When(@"Service Deleted")]
        public void WhenServiceDeleted(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.DeleteService(WorkwaveData.Services.ServiceType);
            System.TimeSpan.FromSeconds(60);
            serviceView.ClickOnStaticText("Remove");
        }
        [Then(@"Verify Service Deleted")]
        public void ThenVerifyServiceDeleted()
        {
            System.TimeSpan.FromSeconds(60);
            Assert.True(serviceView.findElement(WorkwaveData.Services.ServiceType) == null);
        }

        [When(@"Customer Signature Tab added")]
        public void WhenCustomerSignatureTabAdded()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "CUSTOMER SIGNATURE"));
        }


        [When(@"Order Completion")]
        public void WhenOrderCompletion()
        {
            orderPageView.ClickOnText("Stop");
           
        }

        [Then(@"Verify Customer Signature Required")]
        public void ThenVerifyCustomerSignatureRequired()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Need to capture customer signature before completing the order"));
            serviceView.ClickOK();
        }

        [When(@"Employee Signature Tab added")]
        public void WhenEmployeeSignatureTabAdded()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "EMPLOYEE SIGNATURE"));
        }

        [Then(@"Verify Employee Signature Required")]
        public void ThenVerifyEmployeeSignatureRequired()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Need to capture employee signature before completing the order"));
            serviceView.ClickOK();
        }

        [When(@"Service Added with service charge")]
        public void WhenServiceAddedWithServiceCharge(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickPlusIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add"));
            serviceView.ClickOnStaticText("Services");
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Service"));
            serviceView.ClickOnText(WorkwaveData.Services.ServiceType);
            servicePriceString = serviceView.GetservicePrice();
            serviceView.ClickOnStaticText("Add");
        }

        [Then(@"Verify Service Price")]
        public void ThenVerifyServicePrice(Table data)
        {
           
            Assert.True(serviceView.VerifyViewLoadedByContainsText(5, servicePriceString));
            WhenServiceDeleted(data);
        }

        [When(@"Service Added without service charge")]
        public void WhenServiceAddedWithoutServiceCharge(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickPlusIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add"));
            serviceView.ClickOnStaticText("Services");
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Service"));
            serviceView.ClickOnText(WorkwaveData.Services.ServiceType);
            servicePriceString = serviceView.GetservicePrice();
            serviceView.ClickDoNotChargeForServiceToggleButton();
            serviceView.ClickOnStaticText("Add");
        }

        [Then(@"Verify Service Price not added")]
        public void ThenVerifyServicePriceNotAdded(Table data)
        {
            Assert.True(serviceView.VerifyServiceAddedWithOutServicePrice(5, WorkwaveData.Services.ServiceType));
            WhenServiceDeleted(data);
        }

        [Then(@"Verify Service with material Added")]
        public void ThenVerifyServiceWithMaterialAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            GivenMaterialTabOpened(data);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceMaterial));
        }

        [Then(@"Verify Service with product Added")]
        public void ThenVerifyServiceWithProductAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            GivenProductTabOpened(data);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceProduct));
        }

        [Given(@"Pest Tab Opened")]
        public void GivenPestTabOpened(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickPestButton();
        }

        [When(@"Pest Added")]
        public void WhenPestAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickAddIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Target Pests"));
            //serviceView.EnterTextOnCommonField(WorkwaveData.Services.Pest);
            serviceView.ClickOnText(WorkwaveData.Services.Pest);
            serviceView.ClickOnText("Done");
           

        }
        [Then(@"Verify Pest Added")]
        public void ThenVerifyPestAdded()
        {
            Assert.True(serviceView.VerifyViewLoadedByText(5,  WorkwaveData.Services.Pest));
        }

        [When(@"Delete Target Pest")]
        public void WhenDeleteTargetPest(Table data)
        {
            WhenPestAdded(data);
        }

        [Then(@"Verify Pest deleted")]
        public void ThenVerifyPestDeleted()
        {
            Assert.True(serviceView.findElement(WorkwaveData.Services.Pest) == null);
        }

        [When(@"Product Discount Tab Opened")]
        public void WhenProductDiscountTabOpened(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickProductButton();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceProduct));
            productAmount = serviceView.GetProductAmountTwo(WorkwaveData.Services.ServiceProduct);
            productSubTotal = serviceView.GetProMainSubTotalValue();
            updatedServiceAmount = servicePrice - productSubTotal;
            
            serviceView.ClickOnArrowFollowingToTextTwo(WorkwaveData.Services.ServiceProduct);          
        }

        [When(@"Product Discount Added")]
        public void WhenProductDiscountAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
            serviceView.ClickOnText("Add Discount");
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Discount"));
            WorkwaveData.Services.ServiceDiscountDescription = WorkwaveMobileSupport.generateRandomString(10);
            serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountDescription, "Description");

            WorkwaveData.Services.ServiceDiscountAmount = WorkwaveMobileSupport.RandomInt(2);
            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {

                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Percentage");
            }
            else
            {
                serviceView.ClickOnButton(WorkwaveData.Services.ServiceDiscountType);
                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Amount");
            }

            serviceView.ClickOnStaticText("Add");
            double discount = double.Parse(WorkwaveData.Services.ServiceDiscountAmount);

            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {
                discountAmount = (productAmount * discount) / 100;
            }
            else
            {
                discountAmount = discount;               
            }
            updatedProductAmount = productAmount - discountAmount;
            updatedProductSubTotal = productSubTotal - discountAmount;
            expectedServiceSubTotal = subTotal - discountAmount;
            expectedServiceTotal = total - discountAmount;

            serviceDescription = WorkwaveData.Services.ServiceDiscountDescription;

            serviceAmountBefore = updatedServiceAmount;
        }

        [Then(@"Verify Product Discount Exists")]
        public void ThenVerifyProductDiscountExists()
        {
            Assert.True(serviceView.VerifyViewLoadedByText(5, WorkwaveData.Services.ServiceDiscountDescription));
            Assert.True(serviceView.VerifyViewLoadedByContainsText(5, WorkwaveData.Services.ServiceDiscountAmount));
            serviceView.ClickOnStaticText("Save");
        }

        [Then(@"Verify Product Discount Applied")]
        public void ThenVerifyProductDiscountApplied()
        {
            productAmount = serviceView.GetProductAmountTwo(WorkwaveData.Services.ServiceProduct);
            productSubTotal = serviceView.GetProMainSubTotalValue();
            Console.WriteLine(updatedProductAmount);
            Console.WriteLine(productAmount);
            Assert.True(updatedProductAmount.Equals(productAmount));
            Assert.True(updatedProductSubTotal. Equals(productSubTotal));
            serviceView.ClickBack();

        }

        [When(@"Service Added With Product")]
        public void WhenServiceAddedWithProduct(Table data)
        {
            WhenServiceAdded(data);
           // ThenVerifyServiceWithProductAdded(data);
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
            servicePrice = serviceView.GetServiceAmount(WorkwaveData.Services.ServiceType);
        }

        [When(@"Discount Product Edited")]
        public void WhenDiscountProductEdited(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Payment>();
           // serviceView.ClickMainBackButtonTwo();
            serviceView.ClickOnText(serviceDescription);
            WorkwaveData.Services.ServiceDiscountDescription = WorkwaveMobileSupport.generateRandomString(10);
            serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountDescription, "Description");

            WorkwaveData.Services.ServiceDiscountAmount = WorkwaveMobileSupport.RandomInt(2);
            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {

                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Percentage");
            }
            else
            {
                serviceView.ClickOnButton(WorkwaveData.Services.ServiceDiscountType);
                serviceView.EnterTextCommonField(WorkwaveData.Services.ServiceDiscountAmount, "Amount");
            }

            serviceView.ClickOnStaticText("Add");
            double discount = double.Parse(WorkwaveData.Services.ServiceDiscountAmount);
            double newDis, newproductAmount, newproductSubTotal, newsubTotal, newtotal = 0.00;

            newproductAmount = productAmount + discountAmount;
            newproductSubTotal = productSubTotal + discountAmount;
            newsubTotal = subTotal + discountAmount;
            newtotal = total + discountAmount;

            if (WorkwaveData.Services.ServiceDiscountType.Equals("Percent"))
            {
                newDis = (newproductAmount * discount) / 100;              
            }
            else
            {
                newDis = discount;
            }

            updatedProductAmount = newproductAmount - newDis;
            updatedProductSubTotal = newproductSubTotal - newDis;
            expectedServiceSubTotal = newsubTotal - newDis;
            expectedServiceTotal = newtotal - newDis;
            serviceDescription = WorkwaveData.Services.ServiceDiscountDescription;
            serviceAmountBefore = updatedServiceAmount;
            discountAmount = newDis;
        }

        [Then(@"Return To Home On Product")]
        public void ThenReturnToHomeOnProduct(Table data)
        {
            serviceView.ClickOnText("Save");
            serviceView.ClickBack();
            WhenServiceDeleted(data);
        }

        [Then(@"Return To Home On Service Offering")]
        public void ThenReturnToHomeOnServiceOffering(Table data)
        {
            WhenServiceDeleted(data); 
        }


    }
}
