﻿using PawChina.IDal;
using PawChina.Model;
using System.Threading.Tasks;

namespace PawChina.BLL
{
    public class ProductInfoBLL : BaseBLL<Model.ProductInfo>, IBLL.IProductInfoBLL
    {
        /// <summary>
        /// 实现父类抽象方法
        /// </summary>
        /// <returns></returns>
        protected override IBaseDal<Model.ProductInfo> GetModelDal()
        {
            return Factory.DalFactory.Resolve<IProductInfoDal>();
        }

        public async Task<string> QueryAsync(QueryModel model)
        {
            //todo:QueryAsync
            return null;
            //var sqlWhere = new System.Text.StringBuilder();
            //dynamic pms1 = new System.Dynamic.ExpandoObject();
            //dynamic pms2 = new System.Dynamic.ExpandoObject();

            ////展图状态
            //if (model.DataStatus == StatusEnum.Init) { model.DataStatus = StatusEnum.Normal; }
            //sqlWhere.Append(" where DataStatus=@DataStatus");
            //pms1.DataStatus = (int)model.DataStatus;

            ////展图标题
            //if (!model.Title.IsNullOrWhiteSpace())
            //{
            //    sqlWhere.Append(" and DTitle like @DTitle");
            //    pms1.DTitle = string.Format("%{0}%", model.Title);
            //}

            //pms2 = pms1;

            ////排序，没有排序或者有SQLI嫌疑的就变为默认
            //if (model.OrderStr.IsNullOrWhiteSpace() || model.OrderStr.Contains("undefined") || model.OrderStr.IsSQLI())
            //{
            //    model.OrderStr = "DId desc";
            //}
            //pms2.OrderStr = model.OrderStr;

            //return await PageLoadAsync(model, "NoteDisPlayImg", sqlWhere.ToString(), pms1, pms2);
        }
    }
}
