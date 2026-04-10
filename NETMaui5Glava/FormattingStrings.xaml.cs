using NETMaui5Glava.Controls;

namespace NETMaui5Glava;

public partial class FormattingStrings : ContentPage
{
	// Слайдеры для выбора значений цвета
	private readonly Slider _rSlider = new Slider() { Minimum = 0, Maximum = 255 };
	private readonly Slider _gSlider = new Slider() { Minimum = 0, Maximum = 255 };
	private readonly Slider _bSlider = new Slider() { Minimum = 0, Maximum = 255 };
	
	// Метки для отображения занячений (привязываются к Value слайдеров)
	private readonly Label _rLabel = new();
	private readonly Label _gLabel = new();
	private readonly Label _bLabel = new();

	// Экземпляры конвертеров (аналог объявления в ResourceDictionary)
	private readonly DoubleToHexConverter _hexConverter  = new();
	private readonly RgbConverter _rgbConverter  = new();

	public FormattingStrings()
	{
		SetupBindings(); // Настраиваем привязки данных
		SetupLayout(); // Формируем визуальную разметку
	}

	private void SetupBindings()
	{
		// Привязка: текст метки + Value слайдера + Конвертер в Hex + формат строки
		_rLabel.SetBinding(Label.TextProperty, new Binding(nameof(Slider.Value))
		{
			Source = _rSlider,
			StringFormat = "Красный {0}", // Шаблон строки {0} = значение
			Converter = _hexConverter
		});

        _gLabel.SetBinding(Label.TextProperty, new Binding(nameof(Slider.Value))
        {
            Source = _gSlider,
            StringFormat = "Зеленый {0:F0}", // {0:F0} = число без дробной части
            Converter = _hexConverter
        });

        _bLabel.SetBinding(Label.TextProperty, new Binding(nameof(Slider.Value))
        {
            Source = _bSlider,
            StringFormat = "Синий {0:F0}",
            Converter = _hexConverter
        });

		// Объединяем 3 значения в один Color для фона
		var multiBinding = new MultiBinding
		{
			Converter = _rgbConverter,
			Bindings =
			{
				new Binding(nameof(Slider.Value)) { Source = _rSlider },
				new Binding(nameof(Slider.Value)) { Source = _gSlider },
				new Binding(nameof(Slider.Value)) { Source = _bSlider },
            }
		};
		// Применяем привязку к свойству Background текущей страницы
		this.SetBinding(BackgroundProperty, multiBinding);
    }
	private void SetupLayout() 
	{
		// Формируем иерархию: ScrollView -> VerticalStackLayout -> элементы
		Content = new ScrollView
		{
			Content = new VerticalStackLayout
			{
				Children =
				{
					// Порядок добавления = порядок отображения сверху вниз
					_rLabel, _rSlider,
					_gLabel, _gSlider,
					_bLabel, _bSlider,
				}
			}
		};
	}
}