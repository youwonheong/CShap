using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_LINQ테스트
{
    class Profile
    {
        public string Name { get; set; }

        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrprofile =
            {
                new Profile(){Name= "정우성", Height =186 },
                new Profile(){Name="김태희",Height=158},
                new Profile(){Name="고현정",Height=172},
                new Profile(){Name="이문세",Height=178},
                new Profile(){Name="하동문",Height=171},

            };
            // Height가 175미만인 데이터만 추출
            Console.WriteLine("### 무식하게 추출 ###");
            List<Profile> profiles = new List<Profile>();
            foreach(Profile profile in arrprofile)
            {
                if (profile.Height < 175)
                    profiles.Add(profile);
            }
            profiles.Sort((profile1, profile2) => { return profile1.Height - profile2.Height; });
            foreach(var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");
            }
            //LINQ를 이용해 추출
            Console.WriteLine("### 똑똑하게 추출 ###");
            var profiles2 = from profile in arrprofile
                            where profile.Height < 175
                            orderby profile.Height
                            select profile;
            foreach (var profile in profiles2)
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");
            }

        }
    }
}
