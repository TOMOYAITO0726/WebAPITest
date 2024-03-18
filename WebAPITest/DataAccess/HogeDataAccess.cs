using WebAPITest.Model;

namespace WebAPITest.DataAccess
{
    public class HogeDataAccess
    {
        public HogeDataAccess() 
        {
        }
        virtual public HogeResultModel GetHoge(HogeInputModel input)
        {
            HogeResultModel resultModel = new HogeResultModel();
            resultModel.Text = "test";
            resultModel.Status = 0; // 成功

            return resultModel;
        }
    }
}
