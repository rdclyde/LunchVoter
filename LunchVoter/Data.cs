using System;
using System.Collections.Generic;
using System.Web;

namespace LunchVoter
{
    public class Data
    {

        //this function retreives the voters from the file system
        public static String VotersGet()
        {
            //get the list of voters
            String dir = HttpRuntime.AppDomainAppPath;
            String list = System.IO.File.ReadAllText(dir + "/files/voters.txt");
            return list;
        }

        //this function saves the voters to the file system
        //true result = success
        //**NOT YET IMPLEMENTED**
        public static bool VotersSave(String list)
        {
            bool result = false;


            return result;
        }

        //this function creates a new ballot for the datetime specified or gets the GUID of a previously created ballot
        public static String BallotCreate(String datetime)
        {
            //get voters
            String voters = VotersGet();
            voters = voters.Replace("%endtime%", datetime);
            //send create request
            String bid = Inet.BallotCreate(voters);
            //String bid = Inet.RestaurantsAllGet();
            return bid;
        }

        //this function gets the list of restaurants from the server
        public static String RestaurantListGet(string ballotId)
        {
            //get the list of resturants for the ballot
            String json = Inet.RestaurantsBallotGet(ballotId);
            //serialize them into a data object

            return json;
        }
    }
}