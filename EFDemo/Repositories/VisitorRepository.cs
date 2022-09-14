using EFDemo.Models;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EFDemo.Repositories
{
    public class VisitorRepository : IVisitorRepository
    {
        private MicronContext _context;
        public VisitorRepository(MicronContext m)
        {
            _context = m;

        }
        public void AddVisitor(Visitor v)
        {
            if (v == null)
            {
                _context.Visitors.Add(v);
                _context.SaveChanges();
            }
        }
        public List<Visitor> GetAllVisitors()
        {
            return _context.Visitors.ToList();
        }
        public Visitor GetAllVisitor(int id)
        {
            return _context.Visitors.Find(id);
        }
        public bool UpdateVisitor(int id, Visitor v)
        {
            var visitor = _context.Visitors.Find(id);
            if (visitor != null)
            {
                visitor.Name = v.Name;
                visitor.Id = v.Id;
                visitor.Company = v.Company;
                visitor.ContactPerson = v.ContactPerson;
                _context.SaveChanges();
                return true;
            }


            return false;
        }
        public bool DeleteVisitor(int id)
        {
            var v = _context.Visitors.Find(id);
            if (v != null)
            {
                _context.Visitors.Remove(v);
                _context.SaveChanges(true);
                return true;
            }
            return false;
        }


    }
}
