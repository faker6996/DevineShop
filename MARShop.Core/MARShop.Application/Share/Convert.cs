using MARShop.Core.Enum;

namespace MARShop.Application.Share
{
    public static class Convert
    {
        public static string ToSubLink(this string categoryName)
        {
            switch (categoryName)
            {
                case nameof(BlogCategoryType.GrowingInThePRWorld):
                    return "growingInThePRWorld";
                case nameof(BlogCategoryType.MyCorner):
                    return "myCorner";
                case nameof(BlogCategoryType.SeeThinkShare):
                    return "seeThinkShare";
                default: break;
            }
            return "";
        }
    }
}
