namespace OKTW2
{
    public enum Language
    {
        English,
        Chinese,
        Polish,
        Russian
    }

    class LANG
    {
        public static string authOutDatedVersion = "OKTW2 Auth successful; NEW VERSION AVAILABLE; you can update after game";
        public static string authSuccessful = "OKTW2 Auth";
        public static string authError = "OKTW2 Auth error; check chat";

        public static string enable = "Enable";
        public static string config = "Config";
        public static string harass = "Harass";
        public static string disable = "Disable";

        public static string Laneclear = "Lane clear";
        public static string Jungleclear = "Jungle clear";

        public static string utilityAndChampion = "Utility and champion";
        public static string onlyChampion = "Only champion";
        public static string onlyUtility = "Only utility";
        public static string AIOMODE = "AIO MODE";
        public static string PRESSF5TORELOADMODE = "PRESS F5 TO RELOAD MODE";
        public static string OKTWorbwalker = "OKTW orbwalker";
        public static string ORBWALKERMODE = "ORBWALKER MODE";

        public static void SetLang(Language LangSet)
        {
            if (LangSet == Language.Chinese)
            {
                authOutDatedVersion = "OKTW2 驗證成功; 發現新版本; 你可以在遊戲結束後更新";
                authSuccessful = "OKTW2 認證";
                authError = "OKTW2 認證錯誤，檢查遊戲聊天視窗";
                enable = "啟用";
                config = "設定";
                harass = "騷擾";
                disable = "禁用";
                Laneclear = "清線";
                Jungleclear = "清野";
                utilityAndChampion = "功能腳本及英雄腳本";
                onlyChampion = "英雄腳本";
                onlyUtility = "功能腳本";
                AIOMODE = "合集模式";
                PRESSF5TORELOADMODE = "請按下F5重新載入";
                OKTWorbwalker = "OKTW 走砍";
                ORBWALKERMODE = "走砍模式";

            }
            else if (LangSet == Language.Polish)
            {
                authOutDatedVersion = "OKTW2 autoryzacja pomyslna, NOWA WERSJA DOSTEPNA, zaktualizuj po grze";
                authSuccessful = "OKTW2 autoryzacja pomyslna";
                authError = "OKTW2 Blad autoryzacji, sprawdz czat";
                enable = "Wlacz";
                config = "Konfiguracja";
                harass = "Harass";
                disable = "Wyłacz";
                Laneclear = "Lane clear";
                Jungleclear = "Jungle clear";
                utilityAndChampion = "Utility and Champion";
                onlyChampion = "Tylko champion";
                onlyUtility = "Tylko utility";
                AIOMODE = "AIO TRYB";
                PRESSF5TORELOADMODE = "Nacisnij F5 aby zaakceptowac zmiany";
                OKTWorbwalker = "OKTW orbwalker";
                ORBWALKERMODE = "ORBWALKER MODE";

            }
            else if (LangSet == Language.Russian)
            {
                authOutDatedVersion = "OKTW2 Успешная авторизация, ДОСТУПНА НОВАЯ ВЕРСИЯ, обновите после игры";
                authSuccessful = "OKTW2 Успешная авторизация";
                authError = "OKTW2 Ошибка авторизации, проверьте чат";
                enable = "Активировать";
                config = "Конфигурация";
                harass = "Харас";
                disable = "Отключено";
                Laneclear = "Зачистка линии";
                Jungleclear = "Зачистка джунглей";
                utilityAndChampion = "Утилити и Чемпион";
                onlyChampion = "Только чемпион";
                onlyUtility = "Только утилити";
                AIOMODE = "AIO MODE";
                PRESSF5TORELOADMODE = "НАЖМИТЕ F5 ДЛЯ ПЕРЕЗАГРУЗКИ";
                OKTWorbwalker = "OKTW orbwalker";
                ORBWALKERMODE = "ORBWALKER MODE";
            }
        }
    }
}
