using System;
using DALPro.Models;
using System.Collections.Generic; // for IEnumerable 
using System.Linq; // for the ToList() method

namespace DALPro
{
    public class EmployerDAL
    {

        private online_recruitment_systemContext db; // by doing this we are not follwoing the inversion of control principle

        public EmployerDAL()
        {
            db = new online_recruitment_systemContext();
        }

        /// <summary>
        /// Returns a List of Employers in the Databse
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employer> ShowEmployers()
        {
            return db.Employers.ToList(); 
        }

        /// <summary>
        /// Get Employer By id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employer ShowEmplyerByID(int id)
        {
            return db.Employers.Find(id);
        }


        public bool AddEmployer(Employer obj)
        {
            try
            {
                db.Employers.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteEmployer(int id)
        {
            bool isDeleted = false;
            try
            {
                Employer toDelete = db.Employers.Find(id);
                if (toDelete != null) {
                    db.Employers.Remove(toDelete);
                    db.SaveChanges();
                    isDeleted = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return isDeleted;
        }

    }
}
