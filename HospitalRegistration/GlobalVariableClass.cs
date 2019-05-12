using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MySql.Data.MySqlClient;


namespace HospitalRegistration
{
    class GlobalVariableClass
    {
        

        //public void Insert_Into_Billing(MySqlConnection connection, int patient_id, string firstname, string lastname, string address, int diagnosis_id, string medication_IDS, string medication_QTY, decimal consultationFee, decimal totalCost, string str_date)
        public void Insert_Into_Billing(string medication_IDS,string medication_NAME, string medication_QTY , string medication_PRICE)
        {

            

            //extract from xml file
            XmlTextReader reader = new XmlTextReader("data.xml");
            string connectionString = "";
            string[] names = { "server", "database", "uid", "password" };
            string[] values = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                reader.ReadToFollowing(names[i]);
                reader.Read();
                connectionString += names[i] + "=" + reader.Value + ";";
            }

            reader.Close();

            //Connect to Server
            //connection = new MySqlConnection(connectionString);

            string[] stringSeparators = new string[] {","};
            string[] str_med_id = medication_IDS.Split(stringSeparators, StringSplitOptions.None);
            string[] str_med_price = medication_PRICE.Split(stringSeparators, StringSplitOptions.None);
            string[] str_med_qty = medication_QTY.Split(stringSeparators, StringSplitOptions.None);
            string[] str_med_name = medication_NAME.Split(stringSeparators, StringSplitOptions.None);

            //get medicine name, calculate qty, price, and subtotal
            //string[] med_name = new string[str_med_id.Length];
            decimal[] med_price = new decimal[str_med_id.Length];
            decimal[] med_subtotal = new decimal[str_med_id.Length];
            int[] med_qty = new int[str_med_id.Length];
            int[] med_id = new int[str_med_id.Length];

            for (int i = 0; i < str_med_id.Length; i++)
            {
                med_id[i] = int.Parse(str_med_id[i]);
                med_qty[i] = int.Parse(str_med_qty[i]);
                med_price[i] = decimal.Parse(str_med_price[i]);
                med_subtotal[i] = med_qty[i] * med_price[i];
                
            }
            //end calculation


            //connection.Open();


            
            
            //string instruction;
            //       instruction= "INSERT INTO `f_user33`.`Billing` (`bi_id`, `patient_ID`, `bi_FirstName`, `bi_LastName`, `bi_Address`, `diagnosis_ID`, `medication_ID`, `medication_name`, `medication_qty`, `medication_price`, `medication_subTotal`, `bi_Consultation_Fee`, `bi_TotalCost`, `bi_date`) ";
            //       instruction += " VALUES (null, @patient_ID, @bi_FirstName, @bi_LastName, @bi_Address, @diagnosis_ID, @medication_ID, @medication_name, @medication_qty, @medication_price, @medication_subTotal, @bi_Consultation_Fee, @bi_TotalCost, @bi_date)";

            //connection.Close();

        }


        public static string firstName; //{ get; set; }  
        public static string lastName; //{ set; get; }

        public void UserFullName(string v_firstname, string v_lastname, string v_userType)
        {
            setFirstName(v_firstname);
            setLastName(v_lastname);
            setUserType(v_userType);
        }

        public static void setFirstName(string v_firstname)
        {
            firstName = v_firstname;
        }

        public static void setLastName(string v_lastname)
        {
            lastName = v_lastname;
        }

        public static string getFirstName()
        {
            return firstName;
        }

        public static string getLastName()
        {
            return lastName;
        }



        private string userType;

        public void setUserType(string v_usertype)
        {
            userType = v_usertype;
        }

        public string getUserType()
        {
            return userType;
        }

    }




}
