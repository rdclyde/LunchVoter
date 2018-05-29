using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LunchVoter
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //id the user
            //if id positive, goto the page setup routine
            PageSetup();
        }

        private void PageSetup()
        {
            //get the current date
            String da = DateTime.Today.ToString("ddd, d MMM yyyy");
            lbVoteDate.Text = da;
            //check to see if the time is before 11:45
            DateTime dt = DateTime.Now;
            lbTest1.Text = dt.ToString();
            //else check for time after 13:00
            //display the restaurants
            RestaurantsDisplay(dt.ToString("M/d/yy")+" 11:45");
        }

        private void RestaurantsDisplay(String datetime)
        {
            //create/get a ballot
            Data.BallotCreate(datetime);
            //get the restaurants
            //display the restaurants
        }

        private void VoteRecord()
        {
            //get the user's choice
            //send the vote to the server
        }


    }
}