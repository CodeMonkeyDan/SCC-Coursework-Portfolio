//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DSchiefer_CPT206_MealPlanning.Models;


namespace DSchiefer_CPT206_MealPlanning.Controllers;

// controller to handle sending of emails
public class SendMailerController : Controller
{
    // GET: /SendMailer/
    public ActionResult Index()
    {
        return View();
    }


    // method runs when user hit send to email
    [HttpPost]
    public IActionResult SendEmail([FromForm] MailModel _objModelMail)
    {
        Console.WriteLine("SendEmail method was called.");

        // checks if the form data is valid
        if (ModelState.IsValid)
        {
            try
            {
                // create body of email using meal plan
                string body = BuildMealPlanEmailBody(_objModelMail.WeeklyPlan);

                // setup the email
                MailMessage mail = new MailMessage();
                mail.To.Add(_objModelMail.To);
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                // setup gmail smtp settings
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("mealplanningapp777@gmail.com", "zmqs edae cene ztqo");
                smtp.EnableSsl = true;

                // send email
                smtp.Send(mail);

                // after sending go back to home page
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                // print errors to console
                Console.WriteLine("Email Error: " + ex.Message);
                return RedirectToAction("Index", "Home");
            }
        }
        else
        {
            // if data is not valid print error
            Console.WriteLine("ModelState is invalid.");
            foreach (var modelState in ModelState)
            {
                foreach (var error in modelState.Value.Errors)
                {
                    Console.WriteLine($"Field '{modelState.Key}' error: {error.ErrorMessage}");
                }
            }

            // return to home page
            return RedirectToAction("Index", "Home");
        }
    }


    // builds html for email using weekly meal plan data
    private string BuildMealPlanEmailBody(List<DailyMeals> weeklyPlan)
    {
        var body = "<h2>Your Personalized Meal Plan</h2>";

        // loop through each day in weekly plan
        foreach (var dayPlan in weeklyPlan)
        {
            body += $"<h3>Day {weeklyPlan.IndexOf(dayPlan) + 1}</h3>";

            // add breakfast info
            body += $"<p><strong>Breakfast:</strong> ";
            body += dayPlan.Breakfast != null && !string.IsNullOrEmpty(dayPlan.Breakfast.Name)
                ? $"<a href='{dayPlan.Breakfast.RecipeUrl}' target='_blank'>{dayPlan.Breakfast.Name}</a>"
                : "No breakfast listed";
            body += "</p>";

            // add lunch info
            body += $"<p><strong>Lunch:</strong> ";
            body += dayPlan.Lunch != null && !string.IsNullOrEmpty(dayPlan.Lunch.Name)
                ? $"<a href='{dayPlan.Lunch.RecipeUrl}' target='_blank'>{dayPlan.Lunch.Name}</a>"
                : "No lunch listed";
            body += "</p>";

            // add dinner info
            body += $"<p><strong>Dinner:</strong> ";
            body += dayPlan.Dinner != null && !string.IsNullOrEmpty(dayPlan.Dinner.Name)
                ? $"<a href='{dayPlan.Dinner.RecipeUrl}' target='_blank'>{dayPlan.Dinner.Name}</a>"
                : "No dinner listed";
            body += "</p>";
        }

        return body;
    }
}