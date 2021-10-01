using Practico04.Data;

namespace Practico04.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic() 
        {
            context = new NorthwindContext();
        }

    }
}
