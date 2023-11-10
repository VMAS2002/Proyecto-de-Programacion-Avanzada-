using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



public class CertificationsController : Controller
{

    public IActionResult Date()
    {
        var currentDate = DateTime.Now;
        ViewBag.CurrentDate = currentDate;  
        return View(certifications);
    }

    private List<string> certifications = new List<string>
    {
        "AZ-900.pdf",
        "SOA Architect.pdf",
        "Project Manager Professional.pdf",
        "Cisco Certefied Design Associate.pdf"
    };

    public IActionResult Index()
    {
        return View(certifications);
    }

    public IActionResult DownloadCertification(string certificationName)
    {

        return Content("Aquí estaría el PDF");
    }


    public IActionResult Facebook()
    {
        return Redirect("https://www.facebook.com");
    }

    public IActionResult Instagram()
    {
        return Redirect("https://www.instagram.com");
    }

    public IActionResult Twitter()
    {
        return Redirect("https://www.twitter.com");
    }
}
