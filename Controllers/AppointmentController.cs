using Medlatec.Models;
using Medlatec.Services;
using Microsoft.AspNetCore.Mvc;

public class AppointmentController : Controller
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    public IActionResult Index()
    {
        var appointments = _appointmentService.GetAllAppointments();
        return View(appointments);
    }

    public IActionResult Create()
    {
        return View(new Appointment());
    }

    [HttpPost]
    public IActionResult Create(Appointment appointment)
    {
        if (ModelState.IsValid)
        {
            _appointmentService.CreateAppointment(appointment);
            return RedirectToAction("Index");
        }
        return View(appointment);
    }

    public IActionResult Edit(int id)
    {
        var appointment = _appointmentService.GetAppointmentById(id);
        return View(appointment);
    }

    [HttpPost]
    public IActionResult Edit(Appointment appointment)
    {
        if (ModelState.IsValid)
        {
            _appointmentService.UpdateAppointment(appointment);
            return RedirectToAction("Index");
        }
        return View(appointment);
    }

    public IActionResult Delete(int id)
    {
        var appointment = _appointmentService.GetAppointmentById(id);
        return View(appointment);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _appointmentService.DeleteAppointment(id);
        return RedirectToAction("Index");
    }
}
