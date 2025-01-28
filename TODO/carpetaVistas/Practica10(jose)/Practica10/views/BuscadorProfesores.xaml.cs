
using Practica10.Resources.Modelos;
using System.Collections.ObjectModel;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Practica10.views;

public partial class BuscadorProfesores : ContentPage, IQueryAttributable, INotifyPropertyChanged
{
    private string _test;
    public ObservableCollection<Profesor> Profesores { get; set; }

    public Profesor _selectedProfesor = new Profesor
    {
        Nombre = "Nombre", Apellido1 = "Apellido1", Apellido2 = "Apellido2", NumFaltas = 00,
        Estado = "[Fijo / Temporal]", Contacto = "email@domain.dom - 123456789"
    };




    public BuscadorProfesores()
    {
        InitializeComponent();

        Profesores = new ObservableCollection<Profesor>
        {
            new Profesor { Nombre = "Juan", Apellido1 = "Pérez", Apellido2 = "García", NumFaltas = 12, Estado = "Fijo", Contacto = "juan@gmail.com - 691857184" },
            new Profesor { Nombre = "Ana", Apellido1 = "Gómez", Apellido2 = "López", NumFaltas = 2, Estado = "Temporal", Contacto = "ana@gmail.com - 657487594" },
            new Profesor { Nombre = "Luis", Apellido1 = "Fernández", Apellido2 = "Martínez", NumFaltas = 0, Estado = "Fijo", Contacto = "luis@gmail.com - 671284912" },
            new Profesor { Nombre = "María", Apellido1 = "Rodríguez", Apellido2 = "Hernández", NumFaltas = 3, Estado = "Fijo", Contacto = "maria@gmail.com - 634125698" },
            new Profesor { Nombre = "Carlos", Apellido1 = "Sánchez", Apellido2 = "Ruiz", NumFaltas = 5, Estado = "Temporal", Contacto = "carlos@gmail.com - 654879321" },
            new Profesor { Nombre = "Elena", Apellido1 = "Mendoza", Apellido2 = "Jiménez", NumFaltas = 1, Estado = "Fijo", Contacto = "elena@gmail.com - 678214598" },
            new Profesor { Nombre = "Miguel", Apellido1 = "Vargas", Apellido2 = "Castro", NumFaltas = 8, Estado = "Temporal", Contacto = "miguel@gmail.com - 659847123" },
            new Profesor { Nombre = "Laura", Apellido1 = "Morales", Apellido2 = "Díaz", NumFaltas = 0, Estado = "Fijo", Contacto = "laura@gmail.com - 654128739" },
            new Profesor { Nombre = "José", Apellido1 = "Torres", Apellido2 = "Ortiz", NumFaltas = 4, Estado = "Fijo", Contacto = "jose@gmail.com - 678452931" },
            new Profesor { Nombre = "Cristina", Apellido1 = "Romero", Apellido2 = "Navarro", NumFaltas = 6, Estado = "Temporal", Contacto = "cristina@gmail.com - 657194832" },
            new Profesor { Nombre = "Francisco", Apellido1 = "Navarro", Apellido2 = "Cano", NumFaltas = 2, Estado = "Fijo", Contacto = "francisco@gmail.com - 634872159" },
            new Profesor { Nombre = "Isabel", Apellido1 = "González", Apellido2 = "Muñoz", NumFaltas = 9, Estado = "Temporal", Contacto = "isabel@gmail.com - 649875321" },
            new Profesor { Nombre = "Pedro", Apellido1 = "Martínez", Apellido2 = "Pérez", NumFaltas = 3, Estado = "Fijo", Contacto = "pedro@gmail.com - 678154239" },
            new Profesor { Nombre = "Sara", Apellido1 = "Hidalgo", Apellido2 = "López", NumFaltas = 0, Estado = "Fijo", Contacto = "sara@gmail.com - 654123987" },
            new Profesor { Nombre = "Roberto", Apellido1 = "Cruz", Apellido2 = "Santos", NumFaltas = 5, Estado = "Temporal", Contacto = "roberto@gmail.com - 687215943" },
            new Profesor { Nombre = "Andrea", Apellido1 = "Ruiz", Apellido2 = "Vega", NumFaltas = 1, Estado = "Fijo", Contacto = "andrea@gmail.com - 671238594" },
            new Profesor { Nombre = "Ángel", Apellido1 = "Fernández", Apellido2 = "Moreno", NumFaltas = 7, Estado = "Temporal", Contacto = "angel@gmail.com - 679841325" },
            new Profesor { Nombre = "Claudia", Apellido1 = "Ortega", Apellido2 = "Castillo", NumFaltas = 4, Estado = "Fijo", Contacto = "claudia@gmail.com - 659487123" },
            new Profesor { Nombre = "Fernando", Apellido1 = "Silva", Apellido2 = "Rodríguez", NumFaltas = 0, Estado = "Fijo", Contacto = "fernando@gmail.com - 657148932" },
            new Profesor { Nombre = "Sofía", Apellido1 = "Crespo", Apellido2 = "Blanco", NumFaltas = 8, Estado = "Temporal", Contacto = "sofia@gmail.com - 687412593" },
            new Profesor { Nombre = "Javier", Apellido1 = "Luna", Apellido2 = "Gallego", NumFaltas = 3, Estado = "Fijo", Contacto = "javier@gmail.com - 634219487" },
            new Profesor { Nombre = "Lucía", Apellido1 = "Campos", Apellido2 = "Bravo", NumFaltas = 0, Estado = "Fijo", Contacto = "lucia@gmail.com - 658741293" },
            new Profesor { Nombre = "Pablo", Apellido1 = "Iglesias", Apellido2 = "Soler", NumFaltas = 6, Estado = "Temporal", Contacto = "pablo@gmail.com - 678912453" },
            new Profesor { Nombre = "Marta", Apellido1 = "Aguilar", Apellido2 = "Rubio", NumFaltas = 2, Estado = "Fijo", Contacto = "marta@gmail.com - 654789132" },
            new Profesor { Nombre = "Rosa", Apellido1 = "Domínguez", Apellido2 = "Pascual", NumFaltas = 5, Estado = "Temporal", Contacto = "rosa@gmail.com - 659874123" },
            new Profesor { Nombre = "Daniel", Apellido1 = "Rivas", Apellido2 = "Núñez", NumFaltas = 4, Estado = "Fijo", Contacto = "daniel@gmail.com - 678123459" },
            new Profesor { Nombre = "Victoria", Apellido1 = "Salas", Apellido2 = "Lorenzo", NumFaltas = 1, Estado = "Fijo", Contacto = "victoria@gmail.com - 634789215" },
            new Profesor { Nombre = "Alberto", Apellido1 = "Vega", Apellido2 = "Gil", NumFaltas = 7, Estado = "Temporal", Contacto = "alberto@gmail.com - 679215487" },
            new Profesor { Nombre = "Patricia", Apellido1 = "Cortés", Apellido2 = "Bermúdez", NumFaltas = 0, Estado = "Fijo", Contacto = "patricia@gmail.com - 671489213" },
            new Profesor { Nombre = "Iván", Apellido1 = "Serrano", Apellido2 = "Fuentes", NumFaltas = 8, Estado = "Temporal", Contacto = "ivan@gmail.com - 687415239" },
            new Profesor { Nombre = "Beatriz", Apellido1 = "Nieto", Apellido2 = "Hidalgo", NumFaltas = 2, Estado = "Fijo", Contacto = "beatriz@gmail.com - 654821973" },
            new Profesor { Nombre = "Hugo", Apellido1 = "Marín", Apellido2 = "Delgado", NumFaltas = 5, Estado = "Temporal", Contacto = "hugo@gmail.com - 678412935" },
            new Profesor { Nombre = "Teresa", Apellido1 = "López", Apellido2 = "Carrasco", NumFaltas = 4, Estado = "Fijo", Contacto = "teresa@gmail.com - 657489123" },
            new Profesor { Nombre = "Manuel", Apellido1 = "Cabrera", Apellido2 = "Reyes", NumFaltas = 6, Estado = "Temporal", Contacto = "manuel@gmail.com - 678412359" },
            new Profesor { Nombre = "Paula", Apellido1 = "Esteban", Apellido2 = "Peña", NumFaltas = 3, Estado = "Fijo", Contacto = "paula@gmail.com - 654127893" },
            new Profesor { Nombre = "Alba", Apellido1 = "Herrero", Apellido2 = "Mena", NumFaltas = 0, Estado = "Fijo", Contacto = "alba@gmail.com - 671238495" },
            new Profesor { Nombre = "Gabriel", Apellido1 = "Prieto", Apellido2 = "Álvarez", NumFaltas = 7, Estado = "Temporal", Contacto = "gabriel@gmail.com - 679421587" },
            new Profesor { Nombre = "Nuria", Apellido1 = "Pardo", Apellido2 = "Ramírez", NumFaltas = 2, Estado = "Fijo", Contacto = "nuria@gmail.com - 654871239" },
            new Profesor { Nombre = "Santiago", Apellido1 = "Montero", Apellido2 = "Calvo", NumFaltas = 9, Estado = "Temporal", Contacto = "santiago@gmail.com - 678419235" }
        };


        BindingContext = this;
    }

    public string Test
    {
        get => _test;
        set
        {
            if (_test != value)
            {
                _test = value;
                OnPropertyChanged();
            }
        }
    }

    public Profesor SelectedProfesor
    {
        get => _selectedProfesor;
        set
        {
            if (_selectedProfesor != value)
            {
                _selectedProfesor = value;
                OnPropertyChanged();
            }
        }
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.PreviousSelection)
        {
            var profesor = item as Profesor;
            if (profesor != null)
            {
                profesor.IsSelected = false;
            }
        }

        // Se marca el nuevo elemento como seleccionado
        if (SelectedProfesor != null)
        {
            SelectedProfesor.IsSelected = true;
        }
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("test", out var test))
        {
            Test = (string)test;
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async void GoToHelp(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("help");
    }
}