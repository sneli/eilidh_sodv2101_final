using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eilidh_finalproject
{
    internal class Data
    {
        private static List<Music> songs = new List<Music>();

        public static List<Music> GetMusic()
        {
            Music song = new Music()
            {
                SongID = 1,
                SongName = "Alcohol Free",
                Artist = "Twice",
                Duration = "01:52",
                SongFile = Properties.Resources.alcoholfree_twice
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 2,
                SongName = "Answer",
                Artist = "ATEEZ",
                Duration = "05:03",
                SongFile = Properties.Resources.answer_ateez
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 3,
                SongName = "Attention",
                Artist = "New Jeans",
                Duration = "01:49",
                SongFile = Properties.Resources.attention_newjeans
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 4,
                SongName = "Bam Yang Gang",
                Artist = "BIBI",
                Duration = "01:37",
                SongFile = Properties.Resources.bamyanggang_bibi
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 5,
                SongName = "Case 143",
                Artist = "Stray Kids",
                Duration = "01:46",
                SongFile = Properties.Resources.case143_skz
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 6,
                SongName = "Chasing That Feeling",
                Artist = "TOMORROW X TOGETHER",
                Duration = "01:52",
                SongFile = Properties.Resources.chasingthatfeeling_txt
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 7,
                SongName = "Cherry Bomb",
                Artist = "NCT 127",
                Duration = "01:47",
                SongFile = Properties.Resources.cherrybomb_nct
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 8,
                SongName = "Crown",
                Artist = "TOMORROW X TOGETHER",
                Duration = "04:07",
                SongFile = Properties.Resources.crown_txt
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 9,
                SongName = "Easy",
                Artist = "LE SSERAFIM",
                Duration = "03:10",
                SongFile = Properties.Resources.easy_lesserafim
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 10,
                SongName = "Epiphany",
                Artist = "BTS",
                Duration = "01:54",
                SongFile = Properties.Resources.epiphany_bts
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 11,
                SongName = "Euphoria",
                Artist = "BTS",
                Duration = "01:38",
                SongFile = Properties.Resources.euphoria_bts
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 12,
                SongName = "Fearless",
                Artist = "LE SSERAFIM",
                Duration = "02:18",
                SongFile = Properties.Resources.fearless_lesserafim
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 13,
                SongName = "GOGOBEBE",
                Artist = "MAMAMOO",
                Duration = "05:29",
                SongFile = Properties.Resources.gogobebe_mamamoo
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 14,
                SongName = "HIP",
                Artist = "MAMAMOO",
                Duration = "03:14",
                SongFile = Properties.Resources.hip_mamamoo
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 15,
                SongName = "How You Like That",
                Artist = "BLACKPINK",
                Duration = "05:13",
                SongFile = Properties.Resources.howyoulikethat_blackpink
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 16,
                SongName = "Hype Boy",
                Artist = "New Jeans",
                Duration = "01:50",
                SongFile = Properties.Resources.hypeboy_newjeans
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 17,
                SongName = "IN BLOOM",
                Artist = "ZEROBASEONE",
                Duration = "03:51",
                SongFile = Properties.Resources.inbloom_zb1
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 18,
                SongName = "Inception",
                Artist = "ATEEZ",
                Duration = "05:28",
                SongFile = Properties.Resources.inception_ateez
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 19,
                SongName = "I NEED U",
                Artist = "BTS",
                Duration = "01:37",
                SongFile = Properties.Resources.ineedu_bts
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 20,
                SongName = "LALALALA",
                Artist = "Stray Kids",
                Duration = "01:39",
                SongFile = Properties.Resources.lalalala_skz
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 21,
                SongName = "Life Goes On",
                Artist = "BTS",
                Duration = "02:33",
                SongFile = Properties.Resources.lifegoeson_bts
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 22,
                SongName = "LOVE DIVE",
                Artist = "IVE",
                Duration = "04:57",
                SongFile = Properties.Resources.lovedive_ive
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 23,
                SongName = "Lovesick Girls",
                Artist = "BLACKPINK",
                Duration = "04:09",
                SongFile = Properties.Resources.lovesickgirls_blackpink
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 24,
                SongName = "Lucky Girl Syndrome",
                Artist = "Illit",
                Duration = "02:24",
                SongFile = Properties.Resources.luckygirlsyndrome_illit
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 25,
                SongName = "Magnetic",
                Artist = "Illit",
                Duration = "02:58",
                SongFile = Properties.Resources.magnetic_illit
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 26,
                SongName = "New Jeans",
                Artist = "New Jeans",
                Duration = "02:01",
                SongFile = Properties.Resources.newjeans_newjeans
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 27,
                SongName = "OMG",
                Artist = "New Jeans",
                Duration = "01:44",
                SongFile = Properties.Resources.omg_newjeans
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 28,
                SongName = "One Spark",
                Artist = "TWICE",
                Duration = "02:19",
                SongFile = Properties.Resources.onespark_twice
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 29,
                SongName = "Perfect Night",
                Artist = "LE SSERAFIM",
                Duration = "01:36",
                SongFile = Properties.Resources.perfectnight_lesserafim
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 30,
                SongName = "QUEENCARD",
                Artist = "(G)I-DLE",
                Duration = "01:42",
                SongFile = Properties.Resources.queencard_gidle
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 31,
                SongName = "Say My Name",
                Artist = "ATEEZ",
                Duration = "06:39",
                SongFile = Properties.Resources.saymyname_ateez
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 32,
                SongName = "Sheesh",
                Artist = "BABYMONSTER",
                Duration = "02:07",
                SongFile = Properties.Resources.sheesh_babymon
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 33,
                SongName = "Sneakers",
                Artist = "ITZY",
                Duration = "03:36",
                SongFile = Properties.Resources.sneakers_itzy
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 34,
                SongName = "Spring Day",
                Artist = "BTS",
                Duration = "02:04",
                SongFile = Properties.Resources.springday_bts
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 35,
                SongName = "Starry Night",
                Artist = "MAMAMOO",
                Duration = "05:17",
                SongFile = Properties.Resources.starrynight_mamamoo
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 36,
                SongName = "Sticky",
                Artist = "KISS OF LIFE",
                Duration = "01:25",
                SongFile = Properties.Resources.sticky_kissoflife
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 37,
                SongName = "Super Lady",
                Artist = "(G)I-DLE",
                Duration = "01:41",
                SongFile = Properties.Resources.superlady_gidle
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 38,
                SongName = "Supernatural",
                Artist = "New Jeans",
                Duration = "02:48",
                SongFile = Properties.Resources.supernatural_newjeans
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 39,
                SongName = "Super Shy",
                Artist = "New Jeans",
                Duration = "02:13",
                SongFile = Properties.Resources.supershy_newjeans
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 40,
                SongName = "Supersonic",
                Artist = "Fromis_9",
                Duration = "01:28",
                SongFile = Properties.Resources.supersonic_fromis9
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 41,
                SongName = "Sweet Venom",
                Artist = "Enhypen",
                Duration = "01:42",
                SongFile = Properties.Resources.sweetvenom_enhypen
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 42,
                SongName = "The Black Cat Nero",
                Artist = "ATEEZ",
                Duration = "02:27",
                SongFile = Properties.Resources.theblackcatnero_ateez
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 43,
                SongName = "Tomboy",
                Artist = "(G)I-DLE",
                Duration = "01:49",
                SongFile = Properties.Resources.tomboy_gidle
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 44,
                SongName = "WANNABE",
                Artist = "ITZY",
                Duration = "03:57",
                SongFile = Properties.Resources.wannabe_itzy
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 45,
                SongName = "Wave",
                Artist = "ATEEZ",
                Duration = "04:37",
                SongFile = Properties.Resources.wave_ateez
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 46,
                SongName = "Whalien 52",
                Artist = "BTS",
                Duration = "02:38",
                SongFile = Properties.Resources.whalien52_bts
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 47,
                SongName = "Wife",
                Artist = "(G)I-DLE",
                Duration = "01:38",
                SongFile = Properties.Resources.wife_gidle
            };
            songs.Add(song);
            song = new Music()
            {
                SongID = 48,
                SongName = "XO (If You Say So)",
                Artist = "Enhypen",
                Duration = "01:38",
                SongFile = Properties.Resources.xo_enhypen
            };
            songs.Add(song);

            return songs;
        }

        public static void AddMusic(Music song)
        {
            song.SongID = songs.Count > 0 ? songs.Max(s => s.SongID) + 1 : 1;
            songs.Add(song);
        }

        public static void UpdateMusic(Music updatedSong)
        {
            var song = songs.FirstOrDefault(s => s.SongID == updatedSong.SongID);
            if (song != null)
            {
                song.SongName = updatedSong.SongName;
                song.Artist = updatedSong.Artist;
                song.Duration = updatedSong.Duration;
                song.SongFile = updatedSong.SongFile;
            }
        }

        public static void DeleteMusic(int songID)
        {
            var song = songs.FirstOrDefault(s => s.SongID == songID);
            if (song != null)
            {
                songs.Remove(song);
            }
        }
    }
}