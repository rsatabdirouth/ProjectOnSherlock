using ProjectOnSherlock.Models;
using ProjectOnSherlock.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectOnSherlock.Controllers
{
    public class LeadController : ApiController

    {
        SherlockEntities _db = new SherlockEntities();
        [HttpPost]
        public IHttpActionResult GetData() {

            var leads = new List<Lead>();
            var leadsInfos = _db.FINAL3_SP_LEADINFO_DATA(null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null).ToList();


            foreach (var lead in leadsInfos)
            {
                leads.Add(new Lead()
                {
                    AdditionalInformation = lead?.AdditionalInformation,
                    commonleadID = lead.commonleadID,
                    
                    CreatedBy = lead.CreatedBy,
                    CreatedOn = lead.CreatedOn,
                 
                    Description = lead.TransferlogDescription,
                  
                    Email = lead.Email,
                    
                    FullName = lead?.FullName,
                   
                    HomePhone = lead.HomePhone,
                   
                    LeadStatus = lead.LeadStatus,
                  
                    Keyword = lead.Keyword,
                   
                    PostCode = lead?.PostCode,
                    
                    ProductName = lead.ProductName,
                   
                    Source = lead.Source,
                   
                    TransferlogIsActualPrice = lead.TransferlogIsActualPrice,
                    TransferlogPrice = lead.TransferlogPrice,
                    
                    TransferlogTransferredOn = lead.TransferlogTransferredOn,
                    BuyerName = lead.BuyerName,
                  
                    UpdatedBy = lead.UpdatedBy,
                    UpdatedOn = lead.UpdatedOn,
                    
                    WebsiteName = lead?.WebsiteName,
                    WebsiteStatus = lead.WebsiteStatus,
                   

                });
            }

            var Dashboard = new Dashboard() {
            Lead = leads};

           

            return Ok(Dashboard);
        }
    }
}
