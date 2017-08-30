namespace OKTWEvade.Localization
{
    /*******
     * Ostatnia zmiana
     * 25.06.2017
     *******/

    using System;
    using System.Collections.Generic;
    using System.Reflection;

    [Obfuscation(Exclude = true, StripAfterObfuscation = false, ApplyToMembers = true)]
    public class StringConstants
    {
        Dictionary<DisplayName, string> 
            english, german,
            polish, russian, 
            korean, simplifiedChinese, traditionalChinese,
            portuguese, spanish;
        
        public StringConstants()
        {

        }
        
        public Dictionary<DisplayName, string> English
        {
            get
            {
                if (this.english == null)
                {
                    this.english = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Keybinds: " },
                        { DisplayName.EnableEvade, "Enable Evade" },
                        { DisplayName.OnlyDangerousKeybind, "Only dangerous" },
                        { DisplayName.LogicLabel, "Logics: " },
                        { DisplayName.Collision, "Collision" },
                        { DisplayName.CDisable, "Disable" },
                        { DisplayName.CHero, "Hero" },
                        { DisplayName.CMinion, "Minion" },
                        { DisplayName.CBoth, "Both" },
                        { DisplayName.BAlways, "Always" },
                        { DisplayName.BlockAttackMode, "Block auto-attack while evading" },
                        { DisplayName.BlockSpellMode, "Block spell casts while evading" },
                        { DisplayName.BNo, "No" },
                        { DisplayName.BOnlyDangerous, "Only dangerous" },
                        { DisplayName.ReactionTimeSlider, "Reaction time: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Ignore reaction time" },
                        { DisplayName.IgnoreReactionTimeDesc, "If enabled ignores reaction time completely" },
                        { DisplayName.DisableFOW, "Disable FOW Dodgning" },
                        { DisplayName.DisableIfShielded, "Don't dodge if spell shielded" },
                        { DisplayName.DBClickToRemove, "Double-Click to remove skillshot" },
                        { DisplayName.DodgeModeMenu, "Dodge mode" },
                        { DisplayName.DodgeMode_Enabled, "Enabled" },
                        { DisplayName.DodgeMode_MDangerLevel, "Minimal Danger Level to use:  " },
                        { DisplayName.HumanizerMenu, "Humanizer" },
                        { DisplayName.Humanizer_Enabled, "Enable Humanizer" },
                        { DisplayName.Humanizer_EnabledDesc, "Enable Humanizer - Enables the humanizer." },
                        { DisplayName.Humanizer_SDetectionT, "Spell Detection Delay:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "Spell Detection Delay - delay from skillshot detection to attempting to dodge." },
                        { DisplayName.Humanizer_MaxAngle, "Maximum angle:  {0} degrees" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Maximum angle - Maximal angle between evading destination and your champion's forward vector." },
                        { DisplayName.Humanizer_AltTab, "Don't dodge if ALT-Tabbed" },
                        { DisplayName.Humanizer_AltTabDesc, "Don't dodge if ALT-Tabbed - Evade won't dodge if you are alt-tabbed." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Ignore skillshots outside screen" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Ignore skillshots outside screen - Ignores skillshots that are not visible on your screen." },
                        { DisplayName.Humanizer_PlayerNotVisible, "Don't dodge if player is not visible" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\nDon't dodge if player is not visible - If enabled evade won't dodge anything if\nyour champion is not on the screen." },
                        { DisplayName.Humanizer_FOW, "SpellCaster FOW exit" },
                        { DisplayName.Humanizer_FOWDesc, "\nSpellCaster FOW exit - If enabled evade won't dodge skillshots from\nchampions that just exited Fog of War." },
                        { DisplayName.Humanizer_FOWTime, "Minimal Visibility time:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Minimal Visibility time - Minimal time that needs to pass from unit's FOW exit" },
                        { DisplayName.DashHelperMenu, "Dash Helper" },
                        { DisplayName.DashHelper_GlobalEnabled, "Enable Dash Helper" },
                        { DisplayName.DashHelper_SolutionsComboBox, "Solutions: " },
                        { DisplayName.DashHelper_MinHP, "Enabled only if HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Minimal danger level to enable: " },
                        { DisplayName.DashHelper_SBlock, "Block" },
                        { DisplayName.DashHelper_SBlockDesc, "Solution description: Dash helper will block your spell if the end position is in dangerous area." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Override cast position" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Solution description: Dash helper override your spell position if end position is in dangerous area." },
                        { DisplayName.DashHelper_SBoth, "Both" },
                        { DisplayName.DashHelper_SBothDesc, "Solution description: Dash helper override your spell position if end position is in dangerous area\nif not possible spell cast will be blocked." },
                        { DisplayName.DashHelper_HardCC, "Enable only vs HardCC" },
                        { DisplayName.DashHelper_Enabled, "Enabled" },
                        { DisplayName.DrawingsMenu, "Drawings" },
                        { DisplayName.Drawings_GlobalEnabled, "Enable Drawings" },
                        { DisplayName.Drawings_DrawEvadePoint, "Draw Evade Point" },
                        { DisplayName.Drawings_DrawingPreset, "Drawing Preset: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Clear - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simple" },
                        { DisplayName.Drawings_Color, "Drawing Color: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "DeepSkyBlue" },
                        { DisplayName.Drawings_Color_Crimson, "Crimson" },
                        { DisplayName.Drawings_Color_White, "White" },
                        { DisplayName.Drawings_Color_Green, "Green" },
                        { DisplayName.Drawings_Color_Orange, "Orange" },
                        { DisplayName.Drawings_Color_DeepPink, "DeepPink" },
                        { DisplayName.Drawings_Color_LightGreen, "LightGreen" },
                        { DisplayName.Drawings_LineWidth, "Line Width: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Status draw" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Draw Evade Status" },
                        { DisplayName.Drawings_StickToPlayer, "Status - Stick to Player" },
                        { DisplayName.Drawings_StatusScale, "Status scale: {0}%" },


                        { DisplayName.OKTWBrainMenu, "OKTWBrain" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Enable OKTW Brain system" },
                        { DisplayName.OKTWBrain_CircleSpells, "Disable circle spells dodging" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Minimal spell danger level to dodge:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Above 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "Under 40% HP" }

                    };
                }
                return this.english;
            }
        }

        public Dictionary<DisplayName, string> Polish
        {
            get
            {
                if (this.polish == null)
                {
                    this.polish = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Keybindy: " },
                        { DisplayName.EnableEvade, "Włącz evade" },
                        { DisplayName.OnlyDangerousKeybind, "Tylko niebezpieczne spelle" },
                        { DisplayName.LogicLabel, "Logika: " },
                        { DisplayName.Collision, "Kolizja: " },
                        { DisplayName.CDisable, "Wyłącz całkowicie" },
                        { DisplayName.CHero, "Bohaterowie" },
                        { DisplayName.CMinion, "Stwory/Miniony" },
                        { DisplayName.CBoth, "Oba" },
                        { DisplayName.BAlways, "Zawsze" },
                        { DisplayName.BlockAttackMode, "Blokowanie ataków podczas schodzenia: " },
                        { DisplayName.BlockSpellMode, "Blokowanie castów podczas schodzenia: " },
                        { DisplayName.BNo, "Nigdy" },
                        { DisplayName.BOnlyDangerous, "Tylko niebezpieczne spelle" },
                        { DisplayName.ReactionTimeSlider, "Czas reakcji: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Ignoruj ustawienia czasu reakcji" },
                        { DisplayName.IgnoreReactionTimeDesc, "Całkowicie ignoruje ustawienia czasu reakcji" },
                        { DisplayName.DisableFOW, "Wyłącz schodzenie ze spelli z Mgły Wojny" },
                        { DisplayName.DisableIfShielded, "Nie schodź jeśli mam Tarczę Czarów" },
                        { DisplayName.DBClickToRemove, "Podwójny-Click usuwa skillshoty" },
                        { DisplayName.DodgeModeMenu, "Spelle do schodzenia" },
                        { DisplayName.DodgeMode_Enabled, "Włącz" },
                        { DisplayName.DodgeMode_MDangerLevel, "Minimalny Danger Level żeby użyć:  " },
                        { DisplayName.HumanizerMenu, "Humanizer" },
                        { DisplayName.Humanizer_Enabled, "Włącz Humanizer" },
                        { DisplayName.Humanizer_EnabledDesc, "Włącz Humanizer - Włącza globalnie humanizer." },
                        { DisplayName.Humanizer_SDetectionT, "Spell Detection Delay:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "Spell Detection Delay - opóźnia reakcję o ustawiony czas po detekcji skillshota." },
                        { DisplayName.Humanizer_MaxAngle, "Maksymalny kąt:  {0} stopni" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Maksymalny kąt - Ustawia maksymalny kąt jaki może osiągnąć punkt scodzenia między wektorem\nruchu gracza." },
                        { DisplayName.Humanizer_AltTab, "Nie schodź jeśli jestem na ALT-TABIE" },
                        { DisplayName.Humanizer_AltTabDesc, "Alt-Tab - Wyłącza evade jeśli okno Ligi legend nie ma focusu." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Ignoruj skillshoty poza ekranem" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Ignoruj skillshoty poza ekranem - Ignoruje wszystkie skillshoty których nie widzimy na ekranie." },
                        { DisplayName.Humanizer_PlayerNotVisible, "Nie schodź jeśli nasz bohater jest poza ekranem" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\nJeśli ta opcja jest włączona, evade nie będzie schodzić wcale jeśli nasz bohater nie jest na ekranie." },
                        { DisplayName.Humanizer_FOW, "Wyjście z FOW" },
                        { DisplayName.Humanizer_FOWDesc, "\nWyjście z FOW - Jeśli włączone evade będzie ignorować skillshoty od przeciwników, którzy\ndopiero wyszli z Mgły Wojny." },
                        { DisplayName.Humanizer_FOWTime, "Minimalny czas od wyjścia z Mgły Wojny:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Minimalny czas od wyjścia z Mgły Wojny - Minimalny czas, który musi upłynąc od wyjścia\nprzeciwnikaz Mgły Wojny." },
                        { DisplayName.DashHelperMenu, "Dash Helper" },
                        { DisplayName.DashHelper_GlobalEnabled, "Włącz Dash Helper" },
                        { DisplayName.DashHelper_MinHP, "Włącz tylko jeśli moje HP% jest mniejsze lub równe {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Minimalny Danger Level by uruchmić: " },
                        { DisplayName.DashHelper_SolutionsComboBox, "Rozwiązania: " },
                        { DisplayName.DashHelper_SBlock, "Blokuj" },
                        { DisplayName.DashHelper_SBlockDesc, "Opis: Evade zablokuje casta jeśli trafimy w niebezpieczną pozycję." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Nadpisz pozycję" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Opis: Napisuje niebezpieczną pozycję nową, która jest poza skillshotami." },
                        { DisplayName.DashHelper_SBoth, "Oba" },
                        { DisplayName.DashHelper_SBothDesc, "Opis: Wykorzystuje oba rozwiązania jednocześnie" },
                        { DisplayName.DashHelper_HardCC, "Włącz tylko jeśli leci w nas ciężkie CC" },
                        { DisplayName.DashHelper_Enabled, "Włącz" },
                        { DisplayName.DrawingsMenu, "Drawingi" },
                        { DisplayName.Drawings_GlobalEnabled, "Włącz Drawingi" },
                        { DisplayName.Drawings_DrawEvadePoint, "Rysuj punkt schodzenia" },
                        { DisplayName.Drawings_DrawingPreset, "Ustawienia graficzne: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Wyrazisty - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Prosty" },
                        { DisplayName.Drawings_Color, "Kolor: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "Jasno niebieski" },
                        { DisplayName.Drawings_Color_Crimson, "Ciemna czerwień" },
                        { DisplayName.Drawings_Color_White, "Biały" },
                        { DisplayName.Drawings_Color_Green, "Zielony" },
                        { DisplayName.Drawings_Color_Orange, "Pomarańczowy" },
                        { DisplayName.Drawings_Color_DeepPink, "Ciemny róż" },
                        { DisplayName.Drawings_Color_LightGreen, "Jasna zieleń" },
                        { DisplayName.Drawings_LineWidth, "Szerokość linii: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Ustawienia wyświetlania statusu" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Wyświetl status" },
                        { DisplayName.Drawings_StickToPlayer, "Status - Przyklej do gracza" },
                        { DisplayName.Drawings_StatusScale, "Skala statusu: {0}%" },
                        { DisplayName.OKTWBrainMenu, "System Mózgu OKTW" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Włącz System Mózgu OKTW" },
                        { DisplayName.OKTWBrain_CircleSpells, "Nie schodź z okrągłych skillshotów" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Minimalny Danger Level skillshota, aby włączyć schodzenie:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Powyżej 70 procent życia" },
                        { DisplayName.OKTWBrain_40_70Label, "Pomiędzy 40 a 70 procent życia" },
                        { DisplayName.OKTWBrain_Under40Label, "Poniżej 40 procent życia" }
                    };
                }
                return this.polish;
            }
        }

        public Dictionary<DisplayName, string> Russian
        {
            get
            {
                if (this.russian == null)
                {
                    this.russian = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Назначение кнопок: " },
                        { DisplayName.EnableEvade, "Включить уворот" },
                        { DisplayName.OnlyDangerousKeybind, "Только опасные" },
                        { DisplayName.LogicLabel, "Логика: " },
                        { DisplayName.Collision, "Помеха" },
                        { DisplayName.CDisable, "Отключить" },
                        { DisplayName.CHero, "Герой" },
                        { DisplayName.CMinion, "Миньон" },
                        { DisplayName.CBoth, "И то и другое" },
                        { DisplayName.BAlways, "Всегда" },
                        { DisplayName.BlockAttackMode, "Блокировать автоматическую атаку при увороте" },
                        { DisplayName.BlockSpellMode, "Блокировка заклинаний при увороте" },
                        { DisplayName.BNo, "никогда" },
                        { DisplayName.BOnlyDangerous, "Только опасные" },
                        { DisplayName.ReactionTimeSlider, "Время реакции: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Игнорировать время реакции" },
                        { DisplayName.IgnoreReactionTimeDesc, "Если включено полностью игнорирует время реакции" },
                        { DisplayName.DisableFOW, "Отключить уворот из тени войны" },
                        { DisplayName.DisableIfShielded, "Не уклонятся если висит щит" },
                        { DisplayName.DBClickToRemove, "Двойной щелчок чтобы удалить навык" },
                        { DisplayName.DodgeModeMenu, "Режим уворота" },
                        { DisplayName.DodgeMode_Enabled, "Включен" },
                        { DisplayName.DodgeMode_MDangerLevel, "Минимальный уровень опасности для использования:  " },
                        { DisplayName.HumanizerMenu, "Хуманайзер" },
                        { DisplayName.Humanizer_Enabled, "Включить Хуманайзер" },
                        { DisplayName.Humanizer_EnabledDesc, "Включить Хуманайзер - Включает хуманайзер." },
                        { DisplayName.Humanizer_SDetectionT, "Задержка обнаружения заклинаний:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "Задержка обнаружения заклинаний - задержка с обнаружением скиллшотов чтобы попытаться увернуться." },
                        { DisplayName.Humanizer_MaxAngle, "Максимальный угол:  {0} степени" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Максимальный угол - Максимальный угол между уклоняющимся пунктом назначения и передним вектором вашего чемпиона." },
                        { DisplayName.Humanizer_AltTab, "Не уклонятся, если нажал ALT-Tab" },
                        { DisplayName.Humanizer_AltTabDesc, "Не уклонятся, если нажал ALT-Tab - Не уклонятся если вы свернуты." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Игнорировать скиллшоты за пределами экрана" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Игнорировать скиллшоты за пределами экрана - Игнорирует скиллшоты которые не видны на вашем экране." },
                        { DisplayName.Humanizer_PlayerNotVisible, "Не уворачиваться если игрок не виден" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\nНе уворачиваться если игрок не виден - если включен уворот не уворачиваться если ваш чемпион не на экране." },
                        { DisplayName.Humanizer_FOW, "Кастер заклинаний вышедший из тумана войны" },
                        { DisplayName.Humanizer_FOWDesc, "\nКастер заклинаний вышедший из тумана войны - Если активирован уворот не уклонятся от навыков чемпионов, которые только что вышли из тумана войны." },
                        { DisplayName.Humanizer_FOWTime, "Минимальное время видимости:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Минимальное время видимости - минимальное время необходимое для выхода чемпиона из тумана войны" },
                        { DisplayName.DashHelperMenu, "Помощник скачка" },
                        { DisplayName.DashHelper_GlobalEnabled, "Включить помощника скачка" },
                        { DisplayName.DashHelper_SolutionsComboBox, "Решения: " },
                        { DisplayName.DashHelper_MinHP, "Включено только если HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Минимальный уровень опасности для: " },
                        { DisplayName.DashHelper_SBlock, "Блок" },
                        { DisplayName.DashHelper_SBlockDesc, "Описание определения: Помощник скачка блокирует ваше заклинание, \nесли конечная позиция находится в опасной зоне." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Переопределение позиция каста" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Описание определения: Помощник скачка переопределяет \nваше положение заклинания, если конечная позиция находится в опасной зоне." },
                        { DisplayName.DashHelper_SBoth, "И то и другое" },
                        { DisplayName.DashHelper_SBothDesc, "Описание определения: Помощник скачка переопределяет ваше положение \nзаклинания, если конечная позиция находится в опасной \nзоне или невозможно применить заклинание." },
                        { DisplayName.DashHelper_HardCC, "Включить только против жесткого контроля" },
                        { DisplayName.DashHelper_Enabled, "Включить" },
                        { DisplayName.DrawingsMenu, "Очертания" },
                        { DisplayName.Drawings_GlobalEnabled, "Включить очертания" },
                        { DisplayName.Drawings_DrawEvadePoint, "Показывать точку уворота" },
                        { DisplayName.Drawings_DrawingPreset, "Настройка очертаний: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Clear - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simple" },
                        { DisplayName.Drawings_Color, "Цвет очертаний: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "Темно-синий" },
                        { DisplayName.Drawings_Color_Crimson, "Малиновый" },
                        { DisplayName.Drawings_Color_White, "Белый" },
                        { DisplayName.Drawings_Color_Green, "Зеленый" },
                        { DisplayName.Drawings_Color_Orange, "Оранжевый" },
                        { DisplayName.Drawings_Color_DeepPink, "Темно-розовый" },
                        { DisplayName.Drawings_Color_LightGreen, "Салатовый" },
                        { DisplayName.Drawings_LineWidth, "Ширина линии: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Показывать статус" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Показывать статус уворота" },
                        { DisplayName.Drawings_StickToPlayer, "Статус - Привязатся к игроку" },
                        { DisplayName.Drawings_StatusScale, "Шкала статуса: {0}%" },
                        { DisplayName.OKTWBrainMenu, "Умный OKTW" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Включить умную систему OKTW" },
                        { DisplayName.OKTWBrain_CircleSpells, "Отключить уворот круговых заклинаний" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Минимальный уровень опасности заклинаний для уворота:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Выше 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "Ниже 40% HP" }
                    };
                }
                return this.russian;
            }
        }

        public Dictionary<DisplayName, string> Korean
        {
            get
            {
                if (this.korean == null)
                {
                    this.korean = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Keybinds: " },
                        { DisplayName.EnableEvade, "Enable Evade" },
                        { DisplayName.OnlyDangerousKeybind, "Only dangerous" },
                        { DisplayName.LogicLabel, "Logics: " },
                        { DisplayName.Collision, "Collision" },
                        { DisplayName.CDisable, "Disable" },
                        { DisplayName.CHero, "Hero" },
                        { DisplayName.CMinion, "Minion" },
                        { DisplayName.CBoth, "Both" },
                        { DisplayName.BAlways, "Always" },
                        { DisplayName.BlockAttackMode, "Block auto-attack while evading" },
                        { DisplayName.BlockSpellMode, "Block spell casts while evading" },
                        { DisplayName.BNo, "No" },
                        { DisplayName.BOnlyDangerous, "Only dangerous" },
                        { DisplayName.ReactionTimeSlider, "Reaction time: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Ignore reaction time" },
                        { DisplayName.IgnoreReactionTimeDesc, "If enabled ignores reaction time completely" },
                        { DisplayName.DisableFOW, "Disable FOW Dodgning" },
                        { DisplayName.DisableIfShielded, "Don't dodge if spell shielded" },
                        { DisplayName.DBClickToRemove, "Double-Click to remove skillshot" },
                        { DisplayName.DodgeModeMenu, "Dodge mode" },
                        { DisplayName.DodgeMode_Enabled, "Enabled" },
                        { DisplayName.DodgeMode_MDangerLevel, "Minimal Danger Level to use:  " },
                        { DisplayName.HumanizerMenu, "Humanizer" },
                        { DisplayName.Humanizer_Enabled, "Enable Humanizer" },
                        { DisplayName.Humanizer_EnabledDesc, "Enable Humanizer - Enables the humanizer." },
                        { DisplayName.Humanizer_SDetectionT, "Spell Detection Delay:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "Spell Detection Delay - delay from skillshot detection to attempting to dodge." },
                        { DisplayName.Humanizer_MaxAngle, "Maximum angle:  {0} degrees" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Maximum angle - Maximal angle between evading destination and your champion's forward vector." },
                        { DisplayName.Humanizer_AltTab, "Don't dodge if ALT-Tabbed" },
                        { DisplayName.Humanizer_AltTabDesc, "Don't dodge if ALT-Tabbed - Evade won't dodge if you are alt-tabbed." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Ignore skillshots outside screen" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Ignore skillshots outside screen - Ignores skillshots that are not visible on your screen." },
                        { DisplayName.Humanizer_PlayerNotVisible, "Don't dodge if player is not visible" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\nDon't dodge if player is not visible - If enabled evade won't dodge anything if\nyour champion is not on the screen." },
                        { DisplayName.Humanizer_FOW, "SpellCaster FOW exit" },
                        { DisplayName.Humanizer_FOWDesc, "\nSpellCaster FOW exit - If enabled evade won't dodge skillshots from\nchampions that just exited Fog of War." },
                        { DisplayName.Humanizer_FOWTime, "Minimal Visibility time:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Minimal Visibility time - Minimal time that needs to pass from unit's FOW exit" },
                        { DisplayName.DashHelperMenu, "Dash Helper" },
                        { DisplayName.DashHelper_GlobalEnabled, "Enable Dash Helper" },
                        { DisplayName.DashHelper_SolutionsComboBox, "Solutions: " },
                        { DisplayName.DashHelper_MinHP, "Enabled only if HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Minimal danger level to enable: " },
                        { DisplayName.DashHelper_SBlock, "Block" },
                        { DisplayName.DashHelper_SBlockDesc, "Solution description: Dash helper will block your spell if the end position is in dangerous area." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Override cast position" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Solution description: Dash helper override your spell position if end position is in dangerous area." },
                        { DisplayName.DashHelper_SBoth, "Both" },
                        { DisplayName.DashHelper_SBothDesc, "Solution description: Dash helper override your spell position if end position is in dangerous area\nif not possible spell cast will be blocked." },
                        { DisplayName.DashHelper_HardCC, "Enable only vs HardCC" },
                        { DisplayName.DashHelper_Enabled, "Enabled" },
                        { DisplayName.DrawingsMenu, "Drawings" },
                        { DisplayName.Drawings_GlobalEnabled, "Enable Drawings" },
                        { DisplayName.Drawings_DrawEvadePoint, "Draw Evade Point" },
                        { DisplayName.Drawings_DrawingPreset, "Drawing Preset: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Clear - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simple" },
                        { DisplayName.Drawings_Color, "Drawing Color: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "DeepSkyBlue" },
                        { DisplayName.Drawings_Color_Crimson, "Crimson" },
                        { DisplayName.Drawings_Color_White, "White" },
                        { DisplayName.Drawings_Color_Green, "Green" },
                        { DisplayName.Drawings_Color_Orange, "Orange" },
                        { DisplayName.Drawings_Color_DeepPink, "DeepPink" },
                        { DisplayName.Drawings_Color_LightGreen, "LightGreen" },
                        { DisplayName.Drawings_LineWidth, "Line Width: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Status draw" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Draw Evade Status" },
                        { DisplayName.Drawings_StickToPlayer, "Status - Stick to Player" },
                        { DisplayName.Drawings_StatusScale, "Status scale: {0}%" },
                        { DisplayName.OKTWBrainMenu, "OKTWBrain" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Enable OKTW Brain system" },
                        { DisplayName.OKTWBrain_CircleSpells, "Disable circle spells dodging" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Minimal spell danger level to dodge:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Above 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "Under 40% HP" }

                    };
                }
                return this.korean;
            }
        }

        public Dictionary<DisplayName, string> SimplifiedChinese
        {
            get
            {
                if (this.simplifiedChinese == null)
                {
                    this.simplifiedChinese = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Keybinds: " },
                        { DisplayName.EnableEvade, "启用躲避" },
                        { DisplayName.OnlyDangerousKeybind, "当危险时" },
                        { DisplayName.LogicLabel, "逻辑: " },
                        { DisplayName.Collision, "碰撞" },
                        { DisplayName.CDisable, "关闭" },
                        { DisplayName.CHero, "英雄" },
                        { DisplayName.CMinion, "小兵" },
                        { DisplayName.CBoth, "一起" },
                        { DisplayName.BAlways, "一直" },
                        { DisplayName.BlockAttackMode, "躲避时关闭自动攻击" },
                        { DisplayName.BlockSpellMode, "躲避时关闭技能释放" },
                        { DisplayName.BNo, "从不" },
                        { DisplayName.BOnlyDangerous, "当危险时" },
                        { DisplayName.ReactionTimeSlider, "反应时间: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "无视反应时间" },
                        { DisplayName.IgnoreReactionTimeDesc, "If enabled ignores reaction time completely" },
                        { DisplayName.DisableFOW, "关闭在���雾中躲避" },
                        { DisplayName.DisableIfShielded, "取消躲避当有护盾时" },
                        { DisplayName.DBClickToRemove, "双击取消技能" },
                        { DisplayName.DodgeModeMenu, "躲避模式" },
                        { DisplayName.DodgeMode_Enabled, "启用" },
                        { DisplayName.DodgeMode_MDangerLevel, "最低危险等级使用:  " },
                        { DisplayName.HumanizerMenu, "人性化" },
                        { DisplayName.Humanizer_Enabled, "启动人性化" },
                        { DisplayName.Humanizer_EnabledDesc, "启动人性化 - Enables the humanizer." },
                        { DisplayName.Humanizer_SDetectionT, "技能察觉延迟:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "技能察觉延迟- 当技能察觉到躲避启用延迟." },
                        { DisplayName.Humanizer_MaxAngle, "最大角度:  {0} degrees" },
                        { DisplayName.Humanizer_MaxAngleDesc, "最大角度 - 当技能释放,英雄躲避技能最大角度." },
                        { DisplayName.Humanizer_AltTab, "取消躲避当按ALT" },
                        { DisplayName.Humanizer_AltTabDesc, "取消躲避当按AlT - 取消躲避当按Alt." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "当在视野外无视技能" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "当在视野外无视技能 - 当视野不可见时无视技能." },
                        { DisplayName.Humanizer_PlayerNotVisible, "取消躲避当敌人不可见" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\n取消躲避当敌人不可见 - 取消躲避当敌人不可见就算启用evade." },
                        { DisplayName.Humanizer_FOW, "战争迷雾躲避" },
                        { DisplayName.Humanizer_FOWDesc, "\n战争迷雾躲避 - 当在迷雾中取消躲避并离开迷雾." },
                        { DisplayName.Humanizer_FOWTime, "最少反应可察觉时间:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "最少反应可察觉时间 - 最少时间内从迷雾中离开" },
                        { DisplayName.DashHelperMenu, "位移助手" },
                        { DisplayName.DashHelper_GlobalEnabled, "启用位移助手" },
                        { DisplayName.DashHelper_SolutionsComboBox, "方法: " },
                        { DisplayName.DashHelper_MinHP, "启动当 HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "最低危险等级启用: " },
                        { DisplayName.DashHelper_SBlock, "禁止" },
                        { DisplayName.DashHelper_SBlockDesc, "Solution description: 当位置处于危险时,位移助手会禁止取消你的技能." },
                        { DisplayName.DashHelper_SOverrideCastPos, "修正位移地点" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Solution description: 如果目标地点是危险位置会自动修改位移地点." },
                        { DisplayName.DashHelper_SBoth, "一起使用" },
                        { DisplayName.DashHelper_SBothDesc, "解决方法: 如果目标地点是危险位置会自动修改位移地点\n不可能释放的技能会禁止." },
                        { DisplayName.DashHelper_HardCC, "当面对硬控是启用" },
                        { DisplayName.DashHelper_Enabled, "启用" },
                        { DisplayName.DrawingsMenu, "技能范围" },
                        { DisplayName.Drawings_GlobalEnabled, "启用技能范围" },
                        { DisplayName.Drawings_DrawEvadePoint, "启用躲避点" },
                        { DisplayName.Drawings_DrawingPreset, "躲避点预设: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Clear - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simple" },
                        { DisplayName.Drawings_Color, "线圈颜色: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "天空蓝" },
                        { DisplayName.Drawings_Color_Crimson, "深红色" },
                        { DisplayName.Drawings_Color_White, "白色" },
                        { DisplayName.Drawings_Color_Green, "绿色" },
                        { DisplayName.Drawings_Color_Orange, "橙色" },
                        { DisplayName.Drawings_Color_DeepPink, "深粉色" },
                        { DisplayName.Drawings_Color_LightGreen, "淡绿色" },
                        { DisplayName.Drawings_LineWidth, "线宽: " },
                        { DisplayName.Drawings_StatusDrawLabel, "躲避状态" },
                        { DisplayName.Drawings_DrawEvadeStatus, "显示躲避状态" },
                        { DisplayName.Drawings_StickToPlayer, "状态 - 显示在游戏页面" },
                        { DisplayName.Drawings_StatusScale, "状态表: {0}%" },
                        { DisplayName.OKTWBrainMenu, "OKTW智能" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "启用 OKTW 智能系统" },
                        { DisplayName.OKTWBrain_CircleSpells, "关闭范围技能躲避" },
                        { DisplayName.OKTWBrain_MDangerLevel, "最低危险技能躲避等级:  " },
                        { DisplayName.OKTWBrain_Above70Label, "高于 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "低于 40% HP" }

                    };
                }
                return this.simplifiedChinese;
            }
        }

        public Dictionary<DisplayName, string> TraditionalChinese
        {
            get
            {
                if (this.traditionalChinese == null)
                {
                    this.traditionalChinese = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "技能快捷鍵: " },
                        { DisplayName.EnableEvade, "啟用躲避" },
                        { DisplayName.OnlyDangerousKeybind, "當危險時 " },
                        { DisplayName.LogicLabel, "邏輯: " },
                        { DisplayName.Collision, "碰撞" },
                        { DisplayName.CDisable, "關閉" },
                        { DisplayName.CHero, "英雄" },
                        { DisplayName.CMinion, "小兵" },
                        { DisplayName.CBoth, "一起" },
                        { DisplayName.BAlways, "一直" },
                        { DisplayName.BlockAttackMode, "躲避時關閉自動攻擊" },
                        { DisplayName.BlockSpellMode, "躲避時關閉自動攻擊" },
                        { DisplayName.BNo, "從不" },
                        { DisplayName.BOnlyDangerous, "當危險時" },
                        { DisplayName.ReactionTimeSlider, "反應時間: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "無視反應時間" },
                        { DisplayName.IgnoreReactionTimeDesc, "If enabled ignores reaction time completely" },
                        { DisplayName.DisableFOW, "關閉迷霧中躲避" },
                        { DisplayName.DisableIfShielded, "取消躲避如果啟用護盾" },
                        { DisplayName.DBClickToRemove, "雙擊移除技能" },
                        { DisplayName.DodgeModeMenu, "躲避模式" },
                        { DisplayName.DodgeMode_Enabled, "啟用" },
                        { DisplayName.DodgeMode_MDangerLevel, "使用最低躲避等級:  " },
                        { DisplayName.HumanizerMenu, "人性化" },
                        { DisplayName.Humanizer_Enabled, "啟動人性化" },
                        { DisplayName.Humanizer_EnabledDesc, "啟動人性化 - 啟動人性化." },
                        { DisplayName.Humanizer_SDetectionT, "技能察覺延遲:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "技能察覺延遲 - 當技能察覺到躲避延遲." },
                        { DisplayName.Humanizer_MaxAngle, "躲避最大角度:  {0} degrees" },
                        { DisplayName.Humanizer_MaxAngleDesc, "最大角度 - 當技能釋放，英雄躲避角度." },
                        { DisplayName.Humanizer_AltTab,"取消躲避當按ALT " },
                        { DisplayName.Humanizer_AltTabDesc, "當按ALT取消躲避 - 按alt會關閉evade." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "當在視野外無視技能" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "當在視野外無視技能 - 無視技能當不在你的視野中." },
                        { DisplayName.Humanizer_PlayerNotVisible, "取消躲避當敵人不在視野中" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\n取消躲避當敵人不在視野範圍 - 不會躲避任何技能就算啟用evade." },
                        { DisplayName.Humanizer_FOW, "戰爭迷霧躲避" },
                        { DisplayName.Humanizer_FOWDesc, "\n戰陣迷霧躲避 - 只會離開迷霧中而不是躲避技能." },
                        { DisplayName.Humanizer_FOWTime, "最少反應可察覺時間:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "最少察覺時間 - 最少時間內從迷霧中離開" },
                        { DisplayName.DashHelperMenu, "位移助手" },
                        { DisplayName.DashHelper_GlobalEnabled, "啟動位移助手" },
                        { DisplayName.DashHelper_SolutionsComboBox, "方法: " },
                        { DisplayName.DashHelper_MinHP, "啟動當 HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "最低危險等級啟用: " },
                        { DisplayName.DashHelper_SBlock, "禁止" },
                        { DisplayName.DashHelper_SBlockDesc, "使用方法: 當位置處於危險時,位移助手會取消你的技能釋放." },
                        { DisplayName.DashHelper_SOverrideCastPos, "修正位移點" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "使用方法: 如果目標地點在危險位置會自動修改位移地點." },
                        { DisplayName.DashHelper_SBoth, "同時" },
                        { DisplayName.DashHelper_SBothDesc, "使用方法: 如果目標地點在危險位置會自動修改位移地點\n不可能的技能釋放會禁止." },
                        { DisplayName.DashHelper_HardCC, "啟用當對抗硬控" },
                        { DisplayName.DashHelper_Enabled, "啟用" },
                        { DisplayName.DrawingsMenu, "技能範圍" },
                        { DisplayName.Drawings_GlobalEnabled, "啟用技能範圍" },
                        { DisplayName.Drawings_DrawEvadePoint, "啟用躲避點" },
                        { DisplayName.Drawings_DrawingPreset, "躲避點預設: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Clear - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simple" },
                        { DisplayName.Drawings_Color, "顏色: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "天空藍" },
                        { DisplayName.Drawings_Color_Crimson, "深紅色" },
                        { DisplayName.Drawings_Color_White, "白色" },
                        { DisplayName.Drawings_Color_Green, "綠色" },
                        { DisplayName.Drawings_Color_Orange, "橙色" },
                        { DisplayName.Drawings_Color_DeepPink, "深粉色" },
                        { DisplayName.Drawings_Color_LightGreen, "淡綠色" },
                        { DisplayName.Drawings_LineWidth, "線寬: " },
                        { DisplayName.Drawings_StatusDrawLabel, "躲避狀態" },
                        { DisplayName.Drawings_DrawEvadeStatus, "顯示躲避狀態" },
                        { DisplayName.Drawings_StickToPlayer, "狀態 - 顯示在遊戲頁面" },
                        { DisplayName.Drawings_StatusScale, "狀態表: {0}%" },
                        { DisplayName.OKTWBrainMenu, "OKTWB智能" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "啟用 OKTW 智能系統" },
                        { DisplayName.OKTWBrain_CircleSpells, "關閉範圍技能躲避" },
                        { DisplayName.OKTWBrain_MDangerLevel, "最低危險技能躲避等級:  " },
                        { DisplayName.OKTWBrain_Above70Label, "高於 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "低於 40% HP" }

                    };
                }
                return this.traditionalChinese;
            }
        }

        public Dictionary<DisplayName, string> German
        {
            get
            {
                if (this.german == null)
                {
                    this.german = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Tastenkürzel: " },
                        { DisplayName.EnableEvade, "Ausweichen aktivieren" },
                        { DisplayName.OnlyDangerousKeybind, "Nur gefährlich" },
                        { DisplayName.LogicLabel, "Logiken: " },
                        { DisplayName.Collision, "Kollision" },
                        { DisplayName.CDisable, "Ausschalten" },
                        { DisplayName.CHero, "Held" },
                        { DisplayName.CMinion, "Lakaien" },
                        { DisplayName.CBoth, "Beide" },
                        { DisplayName.BAlways, "Immer" },
                        { DisplayName.BlockAttackMode, "Sperre automatische Angriffe während man ausweicht" },
                        { DisplayName.BlockSpellMode, "Sperre Fähigkeiten während man ausweicht" },
                        { DisplayName.BNo, "Niemals" },
                        { DisplayName.BOnlyDangerous, "Nur gefährlich" },
                        { DisplayName.ReactionTimeSlider, "Reaktionszeit: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Ignoriere Reaktionszeit" },
                        { DisplayName.IgnoreReactionTimeDesc, "Wenn aktiviert ignoriere Reaktionszeit komplett" },
                        { DisplayName.DisableFOW, "Deaktiviere FOW Ausweichen" },
                        { DisplayName.DisableIfShielded, "Nicht ausweichen wenn Zauberschield an" },
                        { DisplayName.DBClickToRemove, "Doppelklick um Skillshot zu entfernen" },
                        { DisplayName.DodgeModeMenu, "Ausweichsmodus" },
                        { DisplayName.DodgeMode_Enabled, "Aktiviert" },
                        { DisplayName.DodgeMode_MDangerLevel, "Minimaler Gefahrenlevel um zu benutzen:  " },
                        { DisplayName.HumanizerMenu, "Vermenschlicher" },
                        { DisplayName.Humanizer_Enabled, "Aktiviere Vermenschlicher" },
                        { DisplayName.Humanizer_EnabledDesc, "Aktiviere Vermenschlicher - Aktiviere den Vermenschlicher." },
                        { DisplayName.Humanizer_SDetectionT, "Zauber Erkennungsverzögerung:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "Zaubererkennungsverzögerung - Verzögern der Skillshoterkennung bevor es zu ausweichen versucht." },
                        { DisplayName.Humanizer_MaxAngle, "Maximaler Winkel:  {0} Grad(e)" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Maximaler Winkel - Maximaler Winkel zwischen Ausweichspunkt und Frontalpunk deines Helden." },
                        { DisplayName.Humanizer_AltTab, "Nicht ausweichen wenn ALT-Tabbed" },
                        { DisplayName.Humanizer_AltTabDesc, "Nicht ausweichen wenn ALT-Tabbed - Ausweicher wird nicht ausweichen wenn du alt-tabbed bist." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Ignoriere skillshots außerhalb des Bildschirm" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Ignoriere skillshots außerhalb des Bildschirm - Ignoriert skillshots das nicht auf deinen Bildschirm zu erkennen sind." },
                        { DisplayName.Humanizer_PlayerNotVisible, "Nicht ausweichen wenn Spieler unsichtbar" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\nNicht ausweichen wenn Spieler unsichtbar - Wenn aktiviert wird Ausweicher nichts ausweichen falls \ndein Held nicht auf deinen Bildschirm zu sehen ist." },
                        { DisplayName.Humanizer_FOW, "Zaubersprüche FOW verlassen" },
                        { DisplayName.Humanizer_FOWDesc, "\nZaubersprüche FOW verlassen - Falls aktiviert wird Ausweicher nicht versuchen Skillshots von \nHelden die gerade den Fog of War verlassen haben auszuweichen." },
                        { DisplayName.Humanizer_FOWTime, "Minimaler Sichtbarkeitszeit:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Minimaler Sichtbarkeitszeit - Minimale Zeit dass um sein muss von der Einheit's verlassen des FOW" },
                        { DisplayName.DashHelperMenu, "Sprint Helfer" },
                        { DisplayName.DashHelper_GlobalEnabled, "Aktiviere Sprint Helfer" },
                        { DisplayName.DashHelper_SolutionsComboBox, "Lösungen: " },
                        { DisplayName.DashHelper_MinHP, "Aktiviert nur falls HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Minimaler Gefahrenleven um einzuschalten: " },
                        { DisplayName.DashHelper_SBlock, "Sperren" },
                        { DisplayName.DashHelper_SBlockDesc, "Lösungsbeschreibung: Sprint Helfer wird dein Zauber blockieren falls deine Ausgangsposition in einer gefährlichen stelle ist." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Überschreibe Zauberposition" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Lösungsbeschreibung: Sprint Helfer wird deine Zauberrichtung überschreiben falls deine Ausgangsposition in einer gefährlichen stelle ist." },
                        { DisplayName.DashHelper_SBoth, "Beides" },
                        { DisplayName.DashHelper_SBothDesc, "Lösungsbeschreibung: Sprint Helfer wird deine Zauberrichtung überschreiben falls deine Ausgangsposition in einer gefährlichen stelle ist,\nwenn nicht möglich, wird es den Zauber sperren." },
                        { DisplayName.DashHelper_HardCC, "Aktiviere nur für HardCC" },
                        { DisplayName.DashHelper_Enabled, "Aktiviert" },
                        { DisplayName.DrawingsMenu, "Zeichnungen" },
                        { DisplayName.Drawings_GlobalEnabled, "Aktiviere Zeichnungen" },
                        { DisplayName.Drawings_DrawEvadePoint, "Zeichne Ausweichspunkt" },
                        { DisplayName.Drawings_DrawingPreset, "Zeichnungsvoreinstellungen: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Klar - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Einfach" },
                        { DisplayName.Drawings_Color, "Zeichnungsfarbe: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "Dunkelhimmelblau" },
                        { DisplayName.Drawings_Color_Crimson, "Purpur" },
                        { DisplayName.Drawings_Color_White, "Weiß" },
                        { DisplayName.Drawings_Color_Green, "Grün" },
                        { DisplayName.Drawings_Color_Orange, "Orange" },
                        { DisplayName.Drawings_Color_DeepPink, "Dunkelrosa" },
                        { DisplayName.Drawings_Color_LightGreen, "Hellgrün" },
                        { DisplayName.Drawings_LineWidth, "Liniendicke: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Status zeichnen" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Zeichne Ausweichsstatus" },
                        { DisplayName.Drawings_StickToPlayer, "Status - Bleib beim Spieler" },
                        { DisplayName.Drawings_StatusScale, "Status skalieren: {0}%" },
                        { DisplayName.OKTWBrainMenu, "OKTWBrain" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Aktiviere OKTW Brain System" },
                        { DisplayName.OKTWBrain_CircleSpells, "Schalte kreisformige Zauberausweichen aus" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Minimaler Zauber Gefahrenlevel um auszuweichen:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Über 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "Unter 40% HP" }
                    };
                }
                return this.german;
            }
        }

        public Dictionary<DisplayName, string> Portuguese
        {
            get
            {
                if (this.portuguese == null)
                {
                    this.portuguese = new Dictionary<DisplayName, string>
                    {
                       { DisplayName.KeybindLabel, "Teclas de atalho: " },
                        { DisplayName.EnableEvade, "Ativar Evade" },
                        { DisplayName.OnlyDangerousKeybind, "Apenas em perigo" },
                        { DisplayName.LogicLabel, "Logicas: " },
                        { DisplayName.Collision, "Collision" },
                        { DisplayName.CDisable, "Desativar" },
                        { DisplayName.CHero, "Hero" },
                        { DisplayName.CMinion, "Minion" },
                        { DisplayName.CBoth, "Mesmo" },
                        { DisplayName.BAlways, "Sempre" },
                        { DisplayName.BlockAttackMode, "Bloquear auto ataque enquanto se esquiva" },
                        { DisplayName.BlockSpellMode, "Bloquear feitiços enquanto se esquiva" },
                        { DisplayName.BNo, "Nunca" },
                        { DisplayName.BOnlyDangerous, "Apenas em perigo" },
                        { DisplayName.ReactionTimeSlider, "Tempo de reação: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Ignorar tempo de reação" },
                        { DisplayName.IgnoreReactionTimeDesc, "Se ativado, ignora o tempo de reação completamente" },
                        { DisplayName.DisableFOW, "Desativar desvio de skill em nevoa de guerra" },
                        { DisplayName.DisableIfShielded, "Não desviar com shields" },
                        { DisplayName.DBClickToRemove, "Duplo clique para remover feitiço" },
                        { DisplayName.DodgeModeMenu, "Modo desviar" },
                        { DisplayName.DodgeMode_Enabled, "Ativado" },
                        { DisplayName.DodgeMode_MDangerLevel, "Minimo de nivel de perigo para usar:  " },
                        { DisplayName.HumanizerMenu, "Humanizador" },
                        { DisplayName.Humanizer_Enabled, "Ativar humanizador" },
                        { DisplayName.Humanizer_EnabledDesc, "Ativar humanizador - Ativa o humanizador." },
                        { DisplayName.Humanizer_SDetectionT, "Tempo para detectar feitiços:  {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "Tempo para detectar feitiços - tempo para detectar skills e desviar." },
                        { DisplayName.Humanizer_MaxAngle, "Angulo maximo:  {0} degrees" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Angulo maximo - Angulo maximo em que o seu champion pode desviar." },
                        { DisplayName.Humanizer_AltTab, "Não desvie caso Alt-tab" },
                        { DisplayName.Humanizer_AltTabDesc, "Não desvie caso alt-tab - Evade não desvia caso esteja em alt+tab." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Ignore skillshots caso esteja fora da tela" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Ignore skills fora da sua tela - Ignora skills que não são visiveis por você." },
                        { DisplayName.Humanizer_PlayerNotVisible, "Não desvie caso o player não esteja visivel" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "Não desvie caso o player não esteja visivel - Caso ativado, evade não vai desviar de champions que não estejam visiveis por você." },
                        { DisplayName.Humanizer_FOW, "SpellCaster FOW exit" },
                        { DisplayName.Humanizer_FOWDesc, "Skill saindo da nevoa de guerra - Se ativado, evade não desviara de skills que acabaram de sair de uma area onde você não tinha visão." },
                        { DisplayName.Humanizer_FOWTime, "Minimo de tempo visivel:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Minimo de tempo visivel - Minimo de tempo visivel para detectar a spell que saiu da nevoa de guerra" },
                        { DisplayName.DashHelperMenu, "Ajuda em dashs(lucian E, trist W)" },
                        { DisplayName.DashHelper_GlobalEnabled, "Ativar ajuda em dashs" },
                        { DisplayName.DashHelper_SolutionsComboBox, "Soluções: " },
                        { DisplayName.DashHelper_MinHP, "Ativar só quando a vida esta em %% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Minimo de perigo para ativar: " },
                        { DisplayName.DashHelper_SBlock, "Bloquear" },
                        { DisplayName.DashHelper_SBlockDesc, "Descrição da função: \"Bloquear\" vai cancelar o dash para areas perigosas(ex: Ziggs ult, etc)." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Vá para outra posição" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Descrição da função: \"Vá para outra posição\" Desvia o seu dash para outro local que não seja a area perigosa." },
                        { DisplayName.DashHelper_SBoth, "Ambos" },
                        { DisplayName.DashHelper_SBothDesc, "Solution description: Caso seja possivel cancelar o dash, ele sera cancelado. Caso não seja, ira desviar seu dash para um local seguro." },
                        { DisplayName.DashHelper_HardCC, "Ativar apenas contra HardCC" },
                        { DisplayName.DashHelper_Enabled, "Ativado" },
                        { DisplayName.DrawingsMenu, "Drawings" },
                        { DisplayName.Drawings_GlobalEnabled, "Ativar Desenhos" },
                        { DisplayName.Drawings_DrawEvadePoint, "Mostrar ponto do evade" },
                        { DisplayName.Drawings_DrawingPreset, "Desenho predefinido: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Limpar - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simples" },
                        { DisplayName.Drawings_Color, "Cor dos desenhos: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "Azul escuro" },
                        { DisplayName.Drawings_Color_Crimson, "Crimson" },
                        { DisplayName.Drawings_Color_White, "Branco" },
                        { DisplayName.Drawings_Color_Green, "Verde" },
                        { DisplayName.Drawings_Color_Orange, "Laranja" },
                        { DisplayName.Drawings_Color_DeepPink, "Rosa escuro" },
                        { DisplayName.Drawings_Color_LightGreen, "Verde claro" },
                        { DisplayName.Drawings_LineWidth, "Line Width: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Estado do Evade" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Mostrar estado do Evade" },
                        { DisplayName.Drawings_StickToPlayer, "Status - Stick to Player" },
                        { DisplayName.Drawings_StatusScale, "Status scale: {0}%" },
                        { DisplayName.OKTWBrainMenu, "OKTWBrain" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Ativar OKTW Brain" },
                        { DisplayName.OKTWBrain_CircleSpells, "Desativar desvio de feitiços circulares" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Minimo de nivel de perigo para desviar do feitiço:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Acima de 70% da vida" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% da vida" },
                        { DisplayName.OKTWBrain_Under40Label, "Abaixo de 40% da vida" }

                    };
                }
                return this.portuguese;
            }
        }

        public Dictionary<DisplayName, string> Spanish
        {
            get
            {
                if (this.spanish == null)
                {
                    this.spanish = new Dictionary<DisplayName, string>
                    {
                        { DisplayName.KeybindLabel, "Accesos rapidos: " },
                        { DisplayName.EnableEvade, "Activar Evade." },
                        { DisplayName.OnlyDangerousKeybind, "Solo habilidades peligrosas" },
                        { DisplayName.LogicLabel, "Logica: " },
                        { DisplayName.Collision, "Colision" },
                        { DisplayName.CDisable, "Desactivar" },
                        { DisplayName.CHero, "Campeones" },
                        { DisplayName.CMinion, "Subditos" },
                        { DisplayName.CBoth, "Ambas" },
                        { DisplayName.BAlways, "Siempre" },
                        { DisplayName.BlockAttackMode, "Bloquear autoataques mientras evade." },
                        { DisplayName.BlockSpellMode, "Bloquear habilidades mientras evade." },
                        { DisplayName.BNo, "No" },
                        { DisplayName.BOnlyDangerous, "Solo habilidades preligrosas." },
                        { DisplayName.ReactionTimeSlider, "Tiempo de reaccion: {0}ms" },
                        { DisplayName.IgnoreReactionTime, "Ignorar tiempo de reaccion" },
                        { DisplayName.IgnoreReactionTimeDesc, "Si activas esta opcion se ignora el tiempo de reaccion completamente" },
                        { DisplayName.DisableFOW, "Deshabilitar Evade fuera del FOW." },
                        { DisplayName.DisableIfShielded, "No evadir si tienes escudos." },
                        { DisplayName.DBClickToRemove, "Dobleclick para eliminar esta habilidad." },
                        { DisplayName.DodgeModeMenu, "Modo del evade" },
                        { DisplayName.DodgeMode_Enabled, "Activado" },
                        { DisplayName.DodgeMode_MDangerLevel, "Nivel minimo de peligro para usar:  " },
                        { DisplayName.HumanizerMenu, "Humanizador" },
                        { DisplayName.Humanizer_Enabled, "Activar Humanizador" },
                        { DisplayName.Humanizer_EnabledDesc, "Activar Humanizador - Activa el humanizador." },
                        { DisplayName.Humanizer_SDetectionT, "Tiempo de deteccin de la habilidad: {0}ms" },
                        { DisplayName.Humanizer_SDetectionTDesc, "\nTiempo de deteccion de la habilidad - añade un tiempo que tardara en detectar la \nhabilidad a esquivar." },
                        { DisplayName.Humanizer_MaxAngle, "Angulo maximo:  {0} grados" },
                        { DisplayName.Humanizer_MaxAngleDesc, "Angulo maximo - Angulo maximo entre el punto de evasion y el vector delantero de tu campeon." },
                        { DisplayName.Humanizer_AltTab, "Deshabilitar el evade mientras tienes el juego minimizado." },
                        { DisplayName.Humanizer_AltTabDesc, "El evade no funcionara mientras estas en ALT-Tab, es decir afuera del juego." },
                        { DisplayName.Humanizer_SkillshotsOutsideScreen, "Ignorar habilidades de las que no tienes vision" },
                        { DisplayName.Humanizer_SkillshotsOutsideScreenDesc, "Ignorar las habilidades que no puedes ver - Ignora las habilidades que no puedes ver en tu pantalla." },
                        { DisplayName.Humanizer_PlayerNotVisible, "No evadir si tu campeon no esta en el campo de vision" },
                        { DisplayName.Humanizer_PlayerNotVisibleDesc, "\nNo evadir si tu campeon no esta visible - Con el evade activado no esquivaras nada\nMientras no veas a tu campeon." },
                        { DisplayName.Humanizer_FOW, "Habilidades fuera de tu FOW" },
                        { DisplayName.Humanizer_FOWDesc, "\nHabilidades casteadas fuera de tu FOW - Con esta opcion habilitada no esquivaras habilidades de\ncampeones fuera de tu FOW." },
                        { DisplayName.Humanizer_FOWTime, "Tiempo minimo de visiblidad:  {0}ms" },
                        { DisplayName.Humanizer_FOWTimeDesc, "Tiempo minimo de visibilidad - Tiempo minimo que necesita estar visible la habilidad." },
                        { DisplayName.DashHelperMenu, "Ayuda con habilidades" },
                        { DisplayName.DashHelper_GlobalEnabled, "Activar ayuda con habilidades" },
                        { DisplayName.DashHelper_SolutionsComboBox, "Soluciones: " },
                        { DisplayName.DashHelper_MinHP, "Activar solamente con esta cantidad de vida HP% <= {0}%" },
                        { DisplayName.DashHelper_MinDangerLevel, "Nivel minimo de peligro para activar: " },
                        { DisplayName.DashHelper_SBlock, "Bloquear" },
                        { DisplayName.DashHelper_SBlockDesc, "Descripcion: Con esta opcion se bloqueara una habilidad si la posicion final se encuentra \nen un area peligrosa." },
                        { DisplayName.DashHelper_SOverrideCastPos, "Sobreescribir posicion de una habilidad" },
                        { DisplayName.DashHelper_SOverrideCastPosDesc, "Descripcion: Si tienes una habilidad esto la bloqueara si la posicion de destino esta en \nun area peligrosa" },
                        { DisplayName.DashHelper_SBoth, "Ambos" },
                        { DisplayName.DashHelper_SBothDesc, "Descripcion: La Ayuda con el dash hara que si tu habilidad termina en un area peligrosa\n la sobreescriba. Si no es posible la habilidad casteada sera bloqueada." },
                        { DisplayName.DashHelper_HardCC, "Activar solamente contra mucho CC" },
                        { DisplayName.DashHelper_Enabled, "Activado" },
                        { DisplayName.DrawingsMenu, "Dibujos" },
                        { DisplayName.Drawings_GlobalEnabled, "Activar Dibujos" },
                        { DisplayName.Drawings_DrawEvadePoint, "Mostrar a donde esquivara la habilidad." },
                        { DisplayName.Drawings_DrawingPreset, "Drawing Preset: " },
                        { DisplayName.Drawings_DrawingPreset_Clear, "Claro - OKTW" },
                        { DisplayName.Drawings_DrawingPreset_Simple, "Simple" },
                        { DisplayName.Drawings_Color, "Drawing Color: " },
                        { DisplayName.Drawings_Color_DeepSkyBlue, "Cielo" },
                        { DisplayName.Drawings_Color_Crimson, "Carmesi" },
                        { DisplayName.Drawings_Color_White, "Blanco" },
                        { DisplayName.Drawings_Color_Green, "Verde" },
                        { DisplayName.Drawings_Color_Orange, "Naranja" },
                        { DisplayName.Drawings_Color_DeepPink, "Violeta" },
                        { DisplayName.Drawings_Color_LightGreen, "Verde claro" },
                        { DisplayName.Drawings_LineWidth, "Anchura: " },
                        { DisplayName.Drawings_StatusDrawLabel, "Estatus del evade" },
                        { DisplayName.Drawings_DrawEvadeStatus, "Mostrar estatus del evade" },
                        { DisplayName.Drawings_StickToPlayer, "Estatus siempre con tu campeon" },
                        { DisplayName.Drawings_StatusScale, "Escala del estatus: {0}%" },
                        { DisplayName.OKTWBrainMenu, "OKTWBrain" },
                        { DisplayName.OKTWBrain_GlobalEnabled, "Activar sistema OKTW Brain" },
                        { DisplayName.OKTWBrain_CircleSpells, "No evadir habilidades circulares" },
                        { DisplayName.OKTWBrain_MDangerLevel, "Peligro minimo de la habilidad a esquivar:  " },
                        { DisplayName.OKTWBrain_Above70Label, "Mas de 70% HP" },
                        { DisplayName.OKTWBrain_40_70Label, "40% - 70% HP" },
                        { DisplayName.OKTWBrain_Under40Label, "Menos de 40% HP" }
                    };
                }
                return this.spanish;
            }
        }

        public string GetName(Language language, DisplayName displayName)
        {
            if (Enum.IsDefined(typeof(Language), language) == false)
            {
                return string.Empty;
            }

            if(Enum.IsDefined(typeof(DisplayName), displayName) == false)
            {
                return displayName.ToString();
            }

            try
            {
                foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
                {
                    if (!propertyInfo.Name.Equals(language.ToString(), StringComparison.OrdinalIgnoreCase) ||
                        !propertyInfo.CanRead)
                    {
                        continue;
                    }

                    var translation = propertyInfo.GetValue(this) as Dictionary<DisplayName, string>;

                    string output;

                    if(translation == null)
                    {
                        return displayName.ToString();
                    }

                    return !translation.TryGetValue(displayName, out output) ? string.Empty : output;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return string.Empty;
            }
            return string.Empty;
        }
    }
}