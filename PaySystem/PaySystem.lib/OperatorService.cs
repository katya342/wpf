using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySystem.lib
{
    public class OperatorService
    {
        EntityModel entityModel = new EntityModel();
        public List<Operators> GetOperators()
        {
            List<Operators> operators = new List<Operators>();
            operators = entityModel.Operators.ToList();
            return operators;
        }
        public void AddOperator(Operators operators)
        {
            entityModel.Operators.Add(operators);
            entityModel.SaveChanges();
        }
    }
}
