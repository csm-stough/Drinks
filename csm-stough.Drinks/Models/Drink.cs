﻿using Newtonsoft.Json;

public record Drink(
    [property: JsonProperty("idDrink")] string idDrink,
    [property: JsonProperty("strDrink")] string strDrink,
    [property: JsonProperty("strDrinkAlternate")] object strDrinkAlternate,
    [property: JsonProperty("strTags")] string strTags,
    [property: JsonProperty("strVideo")] object strVideo,
    [property: JsonProperty("strCategory")] string strCategory,
    [property: JsonProperty("strIBA")] string strIBA,
    [property: JsonProperty("strAlcoholic")] string strAlcoholic,
    [property: JsonProperty("strGlass")] string strGlass,
    [property: JsonProperty("strInstructions")] string strInstructions,
    [property: JsonProperty("strInstructionsES")] object strInstructionsES,
    [property: JsonProperty("strInstructionsDE")] string strInstructionsDE,
    [property: JsonProperty("strInstructionsFR")] object strInstructionsFR,
    [property: JsonProperty("strInstructionsIT")] string strInstructionsIT,
    [property: JsonProperty("strInstructionsZH-HANS")] object strInstructionsZHHANS,
    [property: JsonProperty("strInstructionsZH-HANT")] object strInstructionsZHHANT,
    [property: JsonProperty("strDrinkThumb")] string strDrinkThumb,
    [property: JsonProperty("strIngredient1")] string strIngredient1,
    [property: JsonProperty("strIngredient2")] string strIngredient2,
    [property: JsonProperty("strIngredient3")] string strIngredient3,
    [property: JsonProperty("strIngredient4")] string strIngredient4,
    [property: JsonProperty("strIngredient5")] object strIngredient5,
    [property: JsonProperty("strIngredient6")] object strIngredient6,
    [property: JsonProperty("strIngredient7")] object strIngredient7,
    [property: JsonProperty("strIngredient8")] object strIngredient8,
    [property: JsonProperty("strIngredient9")] object strIngredient9,
    [property: JsonProperty("strIngredient10")] object strIngredient10,
    [property: JsonProperty("strIngredient11")] object strIngredient11,
    [property: JsonProperty("strIngredient12")] object strIngredient12,
    [property: JsonProperty("strIngredient13")] object strIngredient13,
    [property: JsonProperty("strIngredient14")] object strIngredient14,
    [property: JsonProperty("strIngredient15")] object strIngredient15,
    [property: JsonProperty("strMeasure1")] string strMeasure1,
    [property: JsonProperty("strMeasure2")] string strMeasure2,
    [property: JsonProperty("strMeasure3")] string strMeasure3,
    [property: JsonProperty("strMeasure4")] object strMeasure4,
    [property: JsonProperty("strMeasure5")] object strMeasure5,
    [property: JsonProperty("strMeasure6")] object strMeasure6,
    [property: JsonProperty("strMeasure7")] object strMeasure7,
    [property: JsonProperty("strMeasure8")] object strMeasure8,
    [property: JsonProperty("strMeasure9")] object strMeasure9,
    [property: JsonProperty("strMeasure10")] object strMeasure10,
    [property: JsonProperty("strMeasure11")] object strMeasure11,
    [property: JsonProperty("strMeasure12")] object strMeasure12,
    [property: JsonProperty("strMeasure13")] object strMeasure13,
    [property: JsonProperty("strMeasure14")] object strMeasure14,
    [property: JsonProperty("strMeasure15")] object strMeasure15,
    [property: JsonProperty("strImageSource")] string strImageSource,
    [property: JsonProperty("strImageAttribution")] string strImageAttribution,
    [property: JsonProperty("strCreativeCommonsConfirmed")] string strCreativeCommonsConfirmed,
    [property: JsonProperty("dateModified")] string dateModified
)
{
    public override string ToString()
    {
        return strDrink;
    }
}