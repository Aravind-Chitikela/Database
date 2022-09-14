using EFDemo.Models;
using System.Collections.Generic;

namespace EFDemo.Repositories
{
    public interface IVisitorRepository
    {
        void AddVisitor(Visitor v);
        List<Visitor> GetAllVisitors();
        Visitor GetAllVisitor(int id);
        bool UpdateVisitor(int id, Visitor value);
        bool DeleteVisitor(int id);
    }
}