using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile
{
    public class WorkwaveMobileUtility
    {
        public static void InitializeWorkwaveData(Table data, ref WorkwaveData WorkwaveData)
        {
            WorkwaveData.Login = data.CreateInstance<Login>();
            WorkwaveData.Order = data.CreateInstance<Order>();
            WorkwaveData.Attachment = data.CreateInstance<Attachment>();

        }
    }
}
