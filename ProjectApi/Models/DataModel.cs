using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web;
using Dapper;

namespace ProjectApi.Models
{
    public class DataModel
    {
        public void insertData(DidiDbData data)
        {
            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["didi"].ToString()))
            {
                cn.Open();
                string sqlcommand = "insert into dididata_20160401  (plan_id, daily_limt, yes_spend, yes_cpc, cat_id, cat_name, cat_cpc, promo_id, promo_strgy, promo_item_cat, promo_imp, promo_click, promo_ctr, promo_tot_spend, promo_cpc, promo_rev, promo_amt, promo_saved, promo_conv, promo_roi, keyword, price_now, pc_score, mb_score, price_limt, keyword_cat, imp, click, ctr, tot_spend, cpc, rev, amt, saved, conv, roi, imp_rank, all_imp, all_click, all_price, all_ctr, all_compe, all_conv, keyword2, price_new, output, adj_p, f_per_cat_p, f_per_p, f_new_price, keyword_id, isdiff, diff_v, pk_type)";
                sqlcommand = sqlcommand + "VALUES (@plan_id, @daily_limt, @yes_spend, @yes_cpc, @cat_id, @cat_name, @cat_cpc, @promo_id, @promo_strgy, @promo_item_cat, @promo_imp, @promo_click, @promo_ctr, @promo_tot_spend, @promo_cpc, @promo_rev, @promo_amt, @promo_saved, @promo_conv, @promo_roi, @keyword, @price_now, @pc_score, @mb_score, @price_limt, @keyword_cat, @imp, @click, @ctr, @tot_spend, @cpc, @rev, @amt, @saved, @conv, @roi, @imp_rank, @all_imp, @all_click, @all_price, @all_ctr, @all_compe, @all_conv, @keyword2, @price_new, @output, @adj_p, @f_per_cat_p, @f_per_p, @f_new_price, @keyword_id, @isdiff, @diff_v, @pk_type)";

                cn.Execute(sqlcommand, data);
                cn.Close();
            }
        }
        public IEnumerable<DidiDbData> GetData()
        {
            string connectStr = ConfigurationManager.ConnectionStrings["didi"].ToString();

            using (var cn = new SqlConnection(connectStr))
            {
                cn.Open();
                IEnumerable<DidiDbData> didiData = null;
                try
                {
                    //diData = await cn.QueryAsync<DidiDbData>("select top 100 *  FROM dididata_20160401");
                    didiData = cn.Query<DidiDbData>("select top 100 *  FROM dididata_20160401");
                }
                catch ( Exception ex)
                {
                    
                }
                cn.Close();
                return didiData;
                
            }
        }
    }
}