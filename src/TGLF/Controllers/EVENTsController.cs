using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TGLF;

namespace TGLF.Controllers
{
    public class EVENTsController : Controller
    {
        private TGLFEntities db = new TGLFEntities();

        // GET: EVENTs
        public ActionResult Index()
        {
            return View(db.EVENTs.ToList());
        }

        //        public JsonResult EventListJSON()
        public ActionResult EventListJSON()
        {
            return View(db.EVENTs.ToList());
        }
        // GET: EVENTs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EVENT eVENT = db.EVENTs.Find(id);
            if (eVENT == null)
            {
                return HttpNotFound();
            }
            return View(eVENT);
        }

        // GET: EVENTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EVENTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FACID,PLYFLD,PLYFLDNO,TOURN_NO,PLYERS_PER_TM,NO_ROUNDS,START_ROUND,R1_FORMAT,R2_FORMAT,R3_FORMAT,R4_FORMAT,R5_FORMAT,R1_COURSE,R2_COURSE,R3_COURSE,R4_COURSE,R5_COURSE,SKINS,NETSKINS,HDCP_PCT,IND_NET,BLIND,IND_GRS,HDCP_TYP,GM_NAME,EV_NAME,TM_SKINS,LEAGUE,X1_COURSE,X2_COURSE,X3_COURSE,X4_COURSE,X5_COURSE,Y1_COURSE,Y2_COURSE,Y3_COURSE,Y4_COURSE,Y5_COURSE,Z1_COURSE,Z2_COURSE,Z3_COURSE,Z4_COURSE,Z5_COURSE,NINER,F_OR_B1,F_OR_B2,F_OR_B3,F_OR_B4,F_OR_B5,MULT_COURSE,RND_ROBIN,SENT_UP,QUOTABASE,TMCAP_PCENT,NOTE_WALKERS,TR_OR_RND,FLIGHTS,RAT_ADJ,SKIN_SPAN_TEE,R6_FORMAT,R6_COURSE,X6_COURSE,Y6_COURSE,Z6_COURSE,F_OR_B6,JUNK,FBNINES,TRUNKDOLL,ROUNDDOLL,SPONSOR,RP_RESULTS,TM_JUNK,POST_SCORES,LEAGRND,LEAGTEEBOX,HDCP_PCT_W,AVG_HDCP,CAPOFFLOW")] EVENT eVENT)
        {
            if (ModelState.IsValid)
            {
                db.EVENTs.Add(eVENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eVENT);
        }

        // GET: EVENTs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EVENT eVENT = db.EVENTs.Find(id);
            if (eVENT == null)
            {
                return HttpNotFound();
            }
            return View(eVENT);
        }

        // POST: EVENTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FACID,PLYFLD,PLYFLDNO,TOURN_NO,PLYERS_PER_TM,NO_ROUNDS,START_ROUND,R1_FORMAT,R2_FORMAT,R3_FORMAT,R4_FORMAT,R5_FORMAT,R1_COURSE,R2_COURSE,R3_COURSE,R4_COURSE,R5_COURSE,SKINS,NETSKINS,HDCP_PCT,IND_NET,BLIND,IND_GRS,HDCP_TYP,GM_NAME,EV_NAME,TM_SKINS,LEAGUE,X1_COURSE,X2_COURSE,X3_COURSE,X4_COURSE,X5_COURSE,Y1_COURSE,Y2_COURSE,Y3_COURSE,Y4_COURSE,Y5_COURSE,Z1_COURSE,Z2_COURSE,Z3_COURSE,Z4_COURSE,Z5_COURSE,NINER,F_OR_B1,F_OR_B2,F_OR_B3,F_OR_B4,F_OR_B5,MULT_COURSE,RND_ROBIN,SENT_UP,QUOTABASE,TMCAP_PCENT,NOTE_WALKERS,TR_OR_RND,FLIGHTS,RAT_ADJ,SKIN_SPAN_TEE,R6_FORMAT,R6_COURSE,X6_COURSE,Y6_COURSE,Z6_COURSE,F_OR_B6,JUNK,FBNINES,TRUNKDOLL,ROUNDDOLL,SPONSOR,RP_RESULTS,TM_JUNK,POST_SCORES,LEAGRND,LEAGTEEBOX,HDCP_PCT_W,AVG_HDCP,CAPOFFLOW")] EVENT eVENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eVENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eVENT);
        }

        // GET: EVENTs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EVENT eVENT = db.EVENTs.Find(id);
            if (eVENT == null)
            {
                return HttpNotFound();
            }
            return View(eVENT);
        }

        // POST: EVENTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EVENT eVENT = db.EVENTs.Find(id);
            db.EVENTs.Remove(eVENT);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
