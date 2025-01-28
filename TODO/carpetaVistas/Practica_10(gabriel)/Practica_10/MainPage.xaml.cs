using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;
namespace Practica_10;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var appointment = new ObservableCollection<SchedulerAppointment>();

        appointment.Add(new SchedulerAppointment()
        {
            Subject = "Business Meeting",
            StartTime = new DateTime(2025, 1, 15, 10, 0, 0),
            EndTime = new DateTime(2025, 1, 15, 11, 0, 0),
            Background = Brush.Pink

        });
        appointment.Add(new SchedulerAppointment()
        {
            Subject = "Conference",
            StartTime = new DateTime(2025, 1, 16, 12, 0, 0),
            EndTime = new DateTime(2025, 1, 17, 13, 0, 0),
            Background = Brush.Green
        });
        appointment.Add(new SchedulerAppointment()
        {
            Subject = "Interview",
            StartTime = new DateTime(2025, 1, 15, 14, 0, 0),
            EndTime = new DateTime(2025, 1, 15, 15, 0, 0),
            Background = Brush.Blue
        });
        
       

        // Assign appointments to the scheduler
        this.SchedulerControl.AppointmentsSource = appointment;
    }

    private void Scheduler_SelectionChanged(object sender, SchedulerSelectionChangedEventArgs e)
    {
        var selectedDate = e.NewValue;
        if (selectedDate.HasValue)
        {
            DayEntry.Text = selectedDate.Value.Day.ToString();
            MonthEntry.Text = selectedDate.Value.Month.ToString();
            YearEntry.Text = selectedDate.Value.Year.ToString();
        }
        else
        {
            DayEntry.Text = string.Empty; 
            MonthEntry.Text = string.Empty;
            YearEntry.Text = string.Empty;
        }
    }
}