using WebAPITest.DataAccess;
using WebAPITest.Model;
using WebAPITest.Base;

namespace WebAPITest.Businesslogic
{
    public class HogeBusinesslogic<A, R> : IHogeBusinesslogic<HogeInputModel, HogeResultModel>
    {
        private HogeDataAccess hogeDataAccess;
        public HogeBusinesslogic(HogeDataAccess hogeDataAccess)
        {
            // DIとしてhogeDataAccessを受け取る
            this.hogeDataAccess = hogeDataAccess;
        }

        public HogeResultModel GetHoge(HogeInputModel input)
        {
            // hogeデータを取得
            HogeResultModel result = hogeDataAccess.GetHoge(input);

            return result;
        }
    }
}