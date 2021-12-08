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
        double subTotal,total,productTotalAmount, updatedSubTotal, updatedTotal, expectedServiceTotal, expectedServiceSubTotal = 0.00;
        string productTotal = null;

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

        [Given("Discount Tab Opened")]
        public void GivenDiscountTabOpened(Table data)
        {
            GivenServicesExist(data);
            WhenDiscountTabOpened();
        }

        [Given(@"No Service Discounts Exist")]
        public void GivenNoServiceDiscountsExist(Table data)
        {
            GivenDiscountTabOpened(data);
        }
        
        [Given(@"Product Tab Opened")]
        public void GivenProductTabOpened(Table data)
        {
           
            WorkwaveMobileSupport.SwipeDownIOS("FORMS");
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

            Console.WriteLine(updatedSubTotal);
            Console.WriteLine(prodVal);
            Console.WriteLine(productTotalAmountUpdated);

            expectedServiceSubTotal = (updatedSubTotal - prodVal)  + productTotalAmountUpdated;

            Console.WriteLine("expectedServiceSubTotal "+expectedServiceSubTotal);
            expectedServiceTotal = (updatedTotal - prodVal) + productTotalAmountUpdated ;
        }

    }
}
