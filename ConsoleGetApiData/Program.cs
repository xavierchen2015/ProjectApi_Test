using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectApi.Models;
using Jil;

namespace ConsoleGetApiData
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequestModel web = new WebRequestModel();

            DidiDbData didi = new DidiDbData();
            string returnStr = web.GetHttpRequest("http://localhost:877/api/GetDate", "GET", null);
            Console.WriteLine(returnStr);

            string returnStr1 = web.GetHttpRequest("http://localhost:877/api/GetData", "POST", "");
            Console.WriteLine(returnStr1);

            string didiStr = "{\"f_per_p\":0,\"adj_p\":0,\"price_new\":0,\"all_conv\":5.58,\"all_compe\":331,\"all_ctr\":3.7,\"all_price\":46,\"all_click\":348,\"all_imp\":8842,\"imp_rank\":34,\"roi\":0,\"conv\":0,\"saved\":0,\"amt\":0,\"rev\":0,\"cpc\":0,\"tot_spend\":0,\"ctr\":0,\"click\":0,\"imp\":5,\"price_limt\":0.37,\"mb_score\":5,\"pc_score\":4,\"price_now\":0.59,\"promo_roi\":0,\"promo_conv\":0,\"promo_saved\":0,\"promo_amt\":0,\"promo_rev\":0,\"promo_cpc\":0.64,\"promo_tot_spend\":152.73,\"promo_ctr\":1.36,\"promo_click\":238,\"promo_imp\":17512,\"cat_cpc\":0.69,\"yes_cpc\":0.28,\"yes_spend\":97.06,\"daily_limt\":150,\"pk_type\":\"1\",\"diff_v\":\"\",\"isdiff\":\"0\",\"keyword_id\":\"257899497270\",\"f_new_price\":\"0\",\"f_per_cat_p\":\"2\",\"output\":\"刪除\",\"keyword2\":\"假玫瑰花\",\"keyword_cat\":\"热词\",\"keyword\":\"假玫瑰花\",\"promo_item_cat\":\"重点宝贝\",\"promo_strgy\":\"ROI优先\",\"promo_id\":\"1\",\"cat_name\":\"小类目\",\"cat_id\":\"50023044\",\"plan_id\":\"1\"}";
            didi = JSON.Deserialize<DidiDbData>(didiStr);
            string returnStr2 = web.GetHttpRequest("http://localhost:877/api/AddData", "POST", didi);
            Console.WriteLine(returnStr2);

            Console.ReadKey();
        }
    }
}
