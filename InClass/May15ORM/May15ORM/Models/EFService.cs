using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace May15ORM.Models
{
    public static class EFService
    {
        private static HREntities1 db = new HREntities1();

        public static jobs Query(Guid id) {

            var q = from e in db.jobs where e.id == id select e;
            return q.FirstOrDefault();
        }

        public static List<jobs> Query(string title, int? salary) {

            var q = from e in db.jobs select e;

            if (!string.IsNullOrEmpty(title))
                q = q.Where(e => e.name == title);

            if (salary.HasValue)
                q = q.Where(e => e.minsalary <= salary && salary <= e.maxsalary);

            return q.ToList();
        }

        public static void Add(jobs newEntry) {

            newEntry.id = Guid.NewGuid(); // 需要先產生一組新的ID
            db.jobs.Add(newEntry);
            db.SaveChanges();
        
        }


        public static void Edit(jobs newEntry) {
            // source entry
            var entry = db.jobs.Find(newEntry.id);
            entry.code = newEntry.code;
            entry.desc = newEntry.desc;
            entry.id = newEntry.id;
            entry.joblocation = newEntry.joblocation;
            entry.maxsalary = newEntry.maxsalary;
            entry.minsalary = newEntry.minsalary;
            entry.name = newEntry.name;
            db.SaveChanges();
            
        }
        public static void Del(Guid id) {
            var entry = db.jobs.Find(id);
            db.jobs.Remove(entry);
            db.SaveChanges();
        }

    }
}