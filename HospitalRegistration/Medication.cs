using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegistration
{
    class Medication
    {
        private string id;
        public string name;
        private string dosage;
        private string stock;
        private string cost;

      
        public Medication(string p_id, string p_name, string p_dosage, string p_stock, string p_cost)
        {
            setID(p_id);
            setName(p_name);
            setDosage(p_dosage);
            setStock(p_stock);
            setCost(p_cost);

        }

        //---------- SET
        public void setID(string p_id)
        {
            this.id = p_id;
        }

        public void setName(string p_name)
        {
            this.name = p_name;
        }


        public void setDosage(string p_dosage)
        {
            this.dosage = p_dosage;
        }

        public void setStock(string p_stock)
        {
            this.stock = p_stock;
        }

        public void setCost(string p_cost)
        {
            this.cost = p_cost;
        }

        //---------- GET

        public string getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getDosage()
        {
            return dosage;
        }

        public string getStock()
        {
            return stock;
        }

        public string getCost()
        {
            return cost;
        }

        //public override string ToString()
       // {
        //    return "ID : " + id + " , FirstName : " + fname + " ,  LasName : " + lname + " , Salary : " + salary;
        //}

    }
}
