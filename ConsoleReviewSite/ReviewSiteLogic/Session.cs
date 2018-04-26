using ReviewSiteData;
using ReviewSiteData.Persistence;

namespace ReviewSiteLogic {

    class Session {

        private WorkUnit workUnit;

        public Session() {
            workUnit = new WorkUnit(new ReviewSiteContext());
        }

        

    }

}