using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Car
    {
        public string Title;
        public string SubTitle;
        public string Details;
        public string SubDetails;
        public string Img;
        public Car()
        {
            Title = "BMW 5 Series";
            SubTitle = "520d M Sport Business Edition 4dr Step Auto [177] 2009 (59)";
            Details = "Over 20, 000 used cars in stock, Nationwide coverage with over 120 dealerships throughout the UK, Speak to our Business Managers for personalised finance quotation to suit your needs,We will take your old car in part exchange";
            SubDetails = "Evans Halshaw Price Guarantee: If you can find an identical Car for less at a Competitor Dealer within 5 Days, we will refund the Price Difference Terms and Conditions apply to the Evans Halshaw Price Guarantee, please click here for more details";
            Img = "https://mm.pinnacledms.com/Image/GetImage.aspx?Width=&Height=0&Type=Used&ImageGuid=c853bcb8-6aff-44b4-80c8-2cf4c7ed33c7&BackgroundColour=%230E6C9F&Tolerance=5&Quality=30";
        }
}
}
