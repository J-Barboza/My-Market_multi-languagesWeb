using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace MyMarket.Resources
{
	public static class Resource
	{
		private static IStringLocalizer stringLocalizer = null;

		public static CultureInfo GetCurrentCulture() => Thread.CurrentThread.CurrentCulture;
		public static IEnumerable<CultureInfo> GetAllCultures() => ((JsonStringLocalizer)stringLocalizer).GetAllCultures();

						public static string lang_principal_product => stringLocalizer["lang_principal_product"];
								public static string Index_Page_Title => stringLocalizer["Index_Page_Title"];
								public static string lang_app_name_display => stringLocalizer["lang_app_name_display"];
								public static string lang_welcome_title => stringLocalizer["lang_welcome_title"];
								public static string lang_learn_about => stringLocalizer["lang_learn_about"];
								public static string lang_home => stringLocalizer["lang_home"];
								public static string lang_must_be_informed => stringLocalizer["lang_must_be_informed"];
								public static string lang_requerid_field => stringLocalizer["lang_requerid_field"];
								public static string lang_category_must_be_informed => stringLocalizer["lang_category_must_be_informed"];
								public static string lang_category_description_must_be_informed => stringLocalizer["lang_category_description_must_be_informed"];
								public static string lang_price => stringLocalizer["lang_price"];
								public static string lang_preferred => stringLocalizer["lang_preferred"];
								public static string lang_quantity => stringLocalizer["lang_quantity"];
								public static string lang_path => stringLocalizer["lang_path"];
								public static string lang_Image_path => stringLocalizer["lang_Image_path"];
								public static string product_name5 => stringLocalizer["product_name5"];
					}
}
