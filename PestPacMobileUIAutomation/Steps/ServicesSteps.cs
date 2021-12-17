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
        double subTotal,total,productTotalAmount, updatedSubTotal, updatedTotal, expectedServiceTotal, expectedServiceSubTotal,servicePrice,updatedServiceAmount = 0.00;
        string productTotal,firstProductValue = null;

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
            WorkwaveData.Services = data.CreateInstance<Services>();
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
            WorkwaveMobileSupport.SwipeDownIOS("SERVICES");
        }


        [Given(@"Product Tab Opened")]
        public void GivenProductTabOpened(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Services>();
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickProductButton();
        }
        
        [When(@"Product Added")]
        public void WhenProductAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Services>();
            serviceView.ClickAddIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Product"));
            serviceView.EnterTextOnCommonField(WorkwaveData.Services.ServiceProduct);
            serviceView.ClickOnStaticText(WorkwaveData.Services.ServiceProduct);

            Assert.True(serviceView.VerifyViewLoadedByHeader(5,"Add "+ WorkwaveData.Services.ServiceProduct));
            WorkwaveData.Services.ServiceProductQuantity = WorkwaveMobileSupport.RandomInt(3);
            WorkwaveData.Services.ServiceProductPrice = serviceView.getPrice();
            serviceView.EnterProductQuantity(WorkwaveData.Services.ServiceProductQuantity);

            productTotal = serviceView.GetProductSubTotal();
            productTotalAmount = serviceView.GetProSubTotalValue();
            Console.WriteLine(productTotalAmount);
            double expectedquan = (Double.Parse(WorkwaveData.Services.ServiceProductQuantity) * Double.Parse(WorkwaveData.Services.ServiceProductPrice));
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
            Assert.True(updatedSubTotal == expectedServiceSubTotal);
            Assert.True(updatedTotal == expectedServiceTotal);
        }

        [When(@"Product Edited")]
        public void WhenProductEdited(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Services>();

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
            WorkwaveData.Services = data.CreateInstance<Services>();

            double existingProdSubTotal = serviceView.GetProMainSubTotalValue();
            firstProductValue = serviceView.getFirstProPrice(WorkwaveData.Services.ServiceProduct);
            double prodVal = serviceView.GetFirstproductValue(WorkwaveData.Services.ServiceProduct);
            serviceView.DeleteProductMaterial(WorkwaveData.Services.ServiceProduct);
            
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
            WorkwaveData.Services = data.CreateInstance<Services>();
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickMaterialButton();
        }

        [When(@"Material Added")]
        public void WhenMaterialAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Services>();
            serviceView.ClickAddIcon();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Material"));
            serviceView.EnterTextOnCommonField(WorkwaveData.Services.ServiceMaterial);
            serviceView.ClickOnStaticText(WorkwaveData.Services.ServiceMaterial);

            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Edit Material"));
            WorkwaveData.Services.ServiceMaterialQuantity = WorkwaveMobileSupport.RandomInt(5);
            serviceView.EnterMaterialQuantity(WorkwaveData.Services.ServiceMaterialQuantity);

            serviceView.ClickOnStaticText("Save");

            Assert.True(serviceView.VerifyViewLoadedByHeader(5, "Add Material"));

        }

        [Then(@"Verify Material Exists")]
        public void ThenVerifyMaterialExists()
        {
            serviceView.ClickBack();
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceMaterial));
        }

        [When(@"Material Edited")]
        public void WhenMaterialEdited(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Services>();
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
            Assert.True(updatedQuantity .Equals(WorkwaveData.Services.ServiceMaterialQuantity));

        }

        [When(@"Material Deleted")]
        public void WhenMaterialDeleted(Table data)
        {
            serviceView.ClickBack();
            WorkwaveData.Services = data.CreateInstance<Services>();
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
            WorkwaveData.Services = data.CreateInstance<Services>();
            subTotal = serviceView.GetSubTotal();
            total = serviceView.GetTotal();
            servicePrice = serviceView.GetServiceAmount(WorkwaveData.Services.ServiceType);
            serviceView.ClickOnArrowFollowingToText(WorkwaveData.Services.ServiceType);
            Assert.True(serviceView.VerifyViewLoadedByHeader(5, WorkwaveData.Services.ServiceType));
            serviceView.ClickProductButton();
            double productTotalAmountUpdated = serviceView.GetProMainSubTotalValue();
            updatedServiceAmount = servicePrice - productTotalAmountUpdated;
            serviceView.ClickDiscountButton();
        }

        [When(@"Discount Added")]
        public void WhenDiscountAdded(Table data)
        {
            WorkwaveData.Services = data.CreateInstance<Services>();
            serviceView.ClickAddIcon();
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
                expectedServiceSubTotal = subTotal - ((updatedServiceAmount * discount) / 100);
                expectedServiceTotal = total - ((updatedServiceAmount * discount) / 100);
            }
            else
            {
                expectedServiceSubTotal = subTotal - discount;
                expectedServiceTotal = total - discount;
            }

            
         
        }

        [Then(@"Verify Discount Exists")]
        public void ThenVerifyDiscountExists()
        {
            Assert.True(serviceView.VerifyViewLoadedByText(5, WorkwaveData.Services.ServiceDiscountDescription));
        }

        [Then(@"Verify Discount Applied")]
        public void ThenVerifyDiscountApplied()
        {
            ThenVerifyServiceTotal();
        }

    }
}
