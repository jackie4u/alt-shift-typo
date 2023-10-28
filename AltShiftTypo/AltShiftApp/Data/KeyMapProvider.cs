namespace AltShiftApp.Data;

public static class KeyMapProvider {

    // Todo: <Medium> Reimplement with better input data 
    // Todo: <Medium> Extend for all keyboard layouts
    public static Dictionary<char, char> us2cz = new () {
    {'1', '+'},
    {'2', 'ě'},
    {'3', 'š'},
    {'4', 'č'},
    {'5', 'ř'},
    {'6', 'ž'},
    {'7', 'ý'},
    {'8', 'á'},
    {'9', 'í'},
    {'0', 'é'},
    {'-', '='},
    {'_', '%'},
    {'=', '´'},
    {'+', 'ˇ'},
    {'[', 'ú'},
    {']', ')'},
    {';', 'ů'},
    // Todo: <Low> Extend for all keys
    };

}