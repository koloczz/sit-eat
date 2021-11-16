using Microsoft.EntityFrameworkCore;
using SitEat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitEat.Data
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Hard Rock Café - Kraków",
                    Description = "Located in the UNESCO World Heritage Market Square, next door to the most famous church in Poland, St. Mary’s Basilica, Hard Rock Krakow will inspire your taste buds to greatness with delicious food, signature cocktails, and the hottest live entertainment in Poland. With room for 130 guests over three spacious floors, our restaurant welcomes locals and tourists alike for delectable dining, top notch entertainment, and unforgettable events. After a delicious meal of American fare, take a stroll through musical history with iconic pieces of memorabilia you can only find at Hard Rock Cafe Krakow. Enjoy freshly prepared American cuisine and classic favorites like our Legendary Burger. From flavorful salads, to savory entrees, our chefs use only the freshest ingredients to create culinary perfection. Experience the difference of Hard Rock’s service with an energetic, hardworking staff, ready to provide you with everything you need to enjoy the perfect meal.",
                    ImagePath = "/img/28088554.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00"
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Hard Rock Cafe - Wroclaw",
                    Description = "Hard Rock Cafe Wrocław is a spacious, state-of-the-art property that boasts a contemporary restaurant with a stage, two modern bars, and a retail store. Conveniently located 13 kilometers from the airport, it’s the perfect place to stop and grab a bite before exploring this diverse Polish city. Hard Rock Cafe Wrocław features two floors decorated with our signature contemporary design, including music memorabilia from top international and local artists. Guests can sit down and enjoy the rock n’ roll history all over the walls while taking a bite of one of our savory dishes, like the Local Legendary® Burger, which is unique to our Wrocław cafe. After your meal, you can even visit our Rock Shop® to pick up a souvenir of your experience.",
                    ImagePath = "/img/30641059.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Nolita Restaurant",
                    Description = "Nolita Restaurant was opened in November 2012, Internationally awarded Chef Jacek Grochowina has named his culinary venture based on Manhattan’s inspiring neighborhood were traditions and modernity have come together. His culinary philosophy is never stop learning. His style is based on creative interpretation of modern French cuisine using polish seasonal ingredients, also loves to put some oriental twist in his dishes. From the very beginning restaurant was planned to be fine dining informal style with only 40 seats and fully open kitchen all the guests can follow the preparation of the dishes.",
                    ImagePath = "/img/26042070.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "Hard Rock Cafe - Warsaw",
                    Description = "Hard Rock Cafe is located in an exclusive Złote Tarasy shopping center in the very heart of the city close to Main Central Railway Station. The restaurant is famous for American cuisine for meat lovers and vegetarians, an extensive cocktails menu and breakfast & lunch special offers. Guests can enjoy live music surrounded by nearly 300 original memorabilia of legendary artists and choose from a variety of clothes, accessories and collectible pins with Hard Rock Cafe logo   Hard Rock Cafe zlokalizowany jest w samym sercu stolicy, przy Centrum Handlowym Złote Tarasy oraz w pobliżu dworca kolejowego Warszawa Centralna. Restauracja słynie z amerykańskiej kuchni i bogatego wyboru koktajli. W swojej ofercie ma również kartę śniadań i lunchów, dania dla wegetarian oraz menu dla dzieci. Goście mogą posłuchać muzyki na żywo w otoczeniu prawie 300 oryginalnych pamiątek muzycznych. Hard Rock Cafe to także sklep z ubraniami, akcesoriami i kolekcjonerskimi pinami z legendarnym logo",
                    ImagePath = "/img/26467404.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "Dyletanci",
                    Description = "Dyletanci focuses on the product. We want to interpret, not change.  We think of food as a multi-layered experience. We want this experience to be stimulating through its quality, taste, and balance. To us the product and it's needs mean the top quality ingredients, our crops, and farms, as well as understanding the place where we live.  Dyletanci is also the most special wine list in Poland. Over 1,400 items, mostly from biodynamic wineries. The producers who stand behind these wines are people who respect the land and its products and in wine seek purity, energy, and emotions. In addition to the cuisine and wine, we focus on decor elements consistent with our thinking about the place - Zalto light glasseware, hand-made ceramics, and works by Polish graphic designers.  Our commitment and attachment to details build the soul of the place where we want our guests to feel comfortable, to feel good.  We, the Dilettantes.",
                    ImagePath = "/img/27614372.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 6,
                    Name = "Concept13",
                    Description = "Restaurant Concept 13 is located on the 5th floor of DH VITKAC. Its large, glassed interior looks out on a beautiful panorama of the capital which can also be enjoyed from the summer terrace. The dishes are international classics with a polish twist partly prepared on teppanyaki grills or in the open kitchen. The uniqueness of our cuisine is based on experience and innovation in food creation as well as on the dedication deriving of the culinary passion of our Chefs. In summer we invite our guests to the terrace. Every weekend from 12.00 to 18.00 we invite Your children to visit a special children’s corner. Our professional babysitters will keep an eye on Your kids.",
                    ImagePath = "/img/43619261.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 7,
                    Name = "Youmiko Vegan Sushi Centrum",
                    Description = "According to the Japanese tradition, sushi is a combination of carefully cooked rice and fresh, tasty ingredients. At Youmiko we serve 100% vegan sushi taking you on a journey to discover the richness and diversity of the plant world.  We source our vegetables both from the local farmers and most exotic places.  Our aim is to mix traditional Japanese approach and Polish creativity to surprise you with new flavours and textures. To ensure the best taste and temperature we always serve our sushi to your table in portions just after preparing it.  We never specify sushi ingredients in our menu as they depend on the availability of fresh vegetables and the creativity of our Sushi Masters. Ask us what we are serving today!  Upon request, we can prepare gluten-free sushi. Please inform us about your food allergies when ordering.",
                    ImagePath = "/img/28326270.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 8,
                    Name = "Champions Sports Bar & Restaurant",
                    Description = "Champions Sports Bar & Restaurant is a great place to cater to sports fans. Enjoy great food while cheering on your favorite team! Experience the sports excitement with us! Our concept is simple: GOOD FOOD Delicious American snacks complemented by a wide choice of spirits and national and international beers. GOOD SPORT Broadcasting of major sporting events on 37 TVs and 2 large projection screens. GOOD TIME An excellent spot to relax among friends and cheer on your favorite sports teams.  Champions Sports Bar Restaurant to bar dla fanów sportu. Ciesz się wspaniałym jedzeniem, kibicując ulubionej drużynie! Przeżyj z nami sportowe emocje! Nasza koncepcja jest prosta: DOBRE JEDZENIE Pyszne amerykańskie przekąski uzupełnione szerokim wyborem alkoholi oraz piw krajowych i międzynarodowych. SPORT Nadawanie najważniejszych wydarzeń sportowych na 37 telewizorach i 2 dużych ekranach projekcyjnych. MIŁO SPĘDZONY CZAS Doskonałe miejsce na relaks z przyjaciółmi i kibicowanie ulubionym drużynom",
                    ImagePath = "/img/26773424.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 9,
                    Name = "Thai Thai Warszawa",
                    Description = "The concept consists of four locations. Each one is different and unique, but they are visibly connected by authentic cuisine, modern, but fully thai-inspired interior and this special ambiance. Outstanding, but authentic dishes, top quality ingridients from around the globe, extremely talented head chef, and a crew of meticulously chosen cooks, from the finest restaurants in his country of origin. Thailand was never closer.",
                    ImagePath = "/img/26728785.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 10,
                    Name = "Czarne Czerwone Zlote Restauracja & Wine Bar",
                    Description = "'Life is too short to drink bad wine' - these famous words by the great German poet, Goethe, summarise our passion and served as an inspiration for creating our wine bar and shop in Warsaw. Together with an exceptional menu designed by the chef Paweł Rosiński, our wines create a truly unmissable pair! Czarne Czerwone Zlote was born out of our great passion for wines and even greater passion for people. We want to encourage celebration of moments - not only those special and important ones but also the usually underapprieciated casual ones. Being located in the centre of Warsaw, our bar is easily accessible while remaining a quiet retreat to enjoy the best wines and outstanding food thanks to the surroundings of old, historic buildings. The friendly and climatic ambience of our venue is enhanced by original brick walls and use of natural materials, wood and rock. Immerse yourself in our warm atmosphere and feel the magic of German wines.",
                    ImagePath = "/img/43431959.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 11,
                    Name = "Enoteka Warszawska",
                    Description = "",
                    ImagePath = "/img/26468459.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 12,
                    Name = "L'arc Varsovie",
                    Description = "Fresh oysters or lobster’s delicate meat? Each decision will be the best one – because each decision is tasty. You don’t have to wait until Thursday – we have an oyster tank and a lobster tank. Our restaurant has the pleasure of serving you fresh seafood seven days a week. To go with the meal you can choose from a wide array of wines and Champagne, among which you can find unique, vintage wines from the world’s best producers.",
                    ImagePath = "/img/27272218.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 13,
                    Name = "Thai Thai Poznan",
                    Description = "Former military barrack complex raised around 1905 has been recently renovated and adapted for new functions, becoming a self-styled culinary heart of Poznań. Amongst many restaurant concepts within the City Park, you may find the newest Thai Thai restaurant with a modern, polished interior, beautifully contrasting with the historical form of the building. It is also worth mentioning the impressive open kitchen, wide offer of premium wines and spirits and top-class authentic Thai cuisine -all the necessary elements for an unforgettable oriental voyage.",
                    ImagePath = "/img/26728801.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 14,
                    Name = "Rynek Restaurant - Sheraton Poznan Hotel",
                    Description = "We take great pride in the best polish produce and culinary traditions, serving beautiful, authentic food which we all associate with comfort and a warm welcome, alongside a great selection of craft beer, wine and cocktails.",
                    ImagePath = "/img/26794429.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 15,
                    Name = "Floor No 2 restaurant - Warsaw Marriott Hotel",
                    Description = "Located in the very heart of Warsaw, Floor No 2 Restaurant with unique view of the city skyline offers a contemporary a breakfast venue and regular restaurant with Mediterranean cuisine for launch and dinners. Besides the restaurant Floor No 2 focus on individual, personalized service and unique atmosphere that is perfectly suitable for meetings, lunches, dinners and corporate parties - you name it, we can do it! Also, we have private dining spaces, suitable for parties or meeting of up to 20 seated guests.",
                    ImagePath = "/img/28916235.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 16,
                    Name = "Youmiko Vegan Sushi Mokotow",
                    Description = "According to the Japanese tradition, sushi is a combination of carefully cooked rice and fresh, tasty ingredients. At Youmiko we serve 100% vegan sushi taking you on a journey to discover the richness and diversity of the plant world.  We source our vegetables both from the local farmers and most exotic places.  Our aim is to mix traditional Japanese approach and Polish creativity to surprise you with new flavours and textures. To ensure the best taste and temperature we always serve our sushi to your table in portions just after preparing it.  We never specify sushi ingredients in our menu as they depend on the availability of fresh vegetables and the creativity of our Sushi Masters. Ask us what we are serving today!  Upon request, we can prepare gluten-free sushi. Please inform us about your food allergies when ordering.",
                    ImagePath = "/img/30414287.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 17,
                    Name = "Les Amis",
                    Description = "Les Amis French restaurant in Warsaw, Poland Flam & Biere",
                    ImagePath = "/img/27936997.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 18,
                    Name = "Hard Rock Cafe - Gdansk",
                    Description = "Experience authentic dining and world class entertainment when you visit Hard Rock Cafe Gdansk. With room for 100 guests, our spacious restaurant and lounge boasts two floors, a modern bar, and a large outdoor patio area. We are located in heart of Gdansk, on Długi Targ Street, between the magnificent four-arched Green Gate gatehouse—built as a palace for Polish monarchs—and Neptune Fountain, the most memorable fountain in Poland and one of the defining symbols of Gdansk. After a delicious meal of delectable American fare, take a stroll through musical history with an extensive collection of musical memorabilia you can only find at Hard Rock Cafe Gdansk.",
                    ImagePath = "/img/28105968.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 19,
                    Name = "Romantyczna Restauracja",
                    Description = "Lorem ipsum",
                    ImagePath = "/img/28029123.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 20,
                    Name = "Hotel Rysy",
                    Description = "Hotel Rysy restaurant serves tasty Polish specialties in the heart of Zakopane. We are only a few steps from Krupówki. Our menu includes gluten-free and vegetarian options. Rysy is the highest peak in Polish Tatras and in our dishes we use the highest quality local products. Smacznego !",
                    ImagePath = "/img/42413778.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 21,
                    Name = "Thai Thai Gdańsk",
                    Description = "The 'Thai Thai' concept consists of four unique locations, visibly connected by authentic cuisine and modern, but fully thai-inspired interior. The exceptional ambiance of the Gdańsk location is the result of merging a modern thai-inspired decoration with monumental brick walls, remainants of four-hundred year old city fortifications. Outstanding, but authentic dishes, top quality ingridients from around the globe, extremely talented head chef, and a crew of meticulously chosen cooks, from the finest restaurants in his country of origin. Thailand was never closer.",
                    ImagePath = "/img/26469506.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 22,
                    Name = "Mercato - Hilton Gdansk",
                    Description = "The name of our restaurant, Mercato, signifies the trade route of Pomerania – via Mercatorum, which historically connected Gdańsk with Southern Poland. Our menu combines local and seasonal products with culinary trends from around the world, using the latest techniques. The four symbols which inspire our menu are rooted in history – the broad bean grain, planted by the Pomeranians in e, the noble Baltic salmon, the ‘Fagas’ which was a large Pomeranian sheep bred on Zulawy, and finally the duck, used as a symbol of birds bred for centuries in Pomerania.",
                    ImagePath = "/img/28220201.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 23,
                    Name = "Eliksir",
                    Description = "Eliksir is a unique place in Tri-City – it is a combination of restaurant, cocktail bar and event space. The keynote in Eliksir is foodpairing, so the art of combining flavors.",
                    ImagePath = "/img/28023560.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 24,
                    Name = "Thai Thai Sopot",
                    Description = "Modern and stylish interior, bustling surroundings and outstanding thai cuisine are the main reasons for the restaurants impressive popularity amongst both tourists and locals. Close proximity of the sea make our seafood-based dishes higly popular.",
                    ImagePath = "/img/27039418.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 25,
                    Name = "TOP GUN Grill Bar",
                    Description = "TOP GUN GRILL BAR GDANSK  Eat, Drink and Fly... High American Restaurant Słoneczna Morena",
                    ImagePath = "/img/28985533.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 26,
                    Name = "Zaglebie Smaku - Holiday Inn Dabrowa Gornicza",
                    Description = "The “Zagłębie Smaku” Restaurant is located on the first floor and is sure to impress you with its elegant interior design. International dishes served here have a regional flavour and will satisfy the most demanding palates. “Zaglebie Smaku” is a great place for a business lunch, a gala dinner or a Sunday brunch with friends and family.",
                    ImagePath = "/img/25734955.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 27,
                    Name = "Panorama Sky Bar - Warsaw Marriott Hotel",
                    Description = "Panorama Sky Bar is situated on the 40th floor from which our guests can enjoy breathtaking views of Warsaw. But our handcrafted cocktails and infused alcoholic beverages prepared with herbs are the main reasons why you should visit us. We guarantee unique taste sensations!  Panorama Sky Bar znajduje się na 40. piętrze, z którego nasi goście mogą podziwiać zapierające dech w piersiach widoki na Warszawę. Jednak to nasze ręcznie robione koktajle i alkohole infuzowane ziołami są głównym powodem, dla którego warto nas odwiedzić. Gwarantujemy wyjątkowe doznania smakowe!",
                    ImagePath = "/img/26421988.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 28,
                    Name = "Filipa 18 Food Wine Art - Indigo Krakow",
                    Description = "Filipa 18 Food Wine Art Restaurant  Food Chef Marcin Sołtys has created a menu inspired by traditional polish cuisine in a modern style and regional products from the oldest market in Krakow - Stary Kleparz. Each dish is created on our open kitchen.  Wine Culinary adventure in Filipa 18 Food Wine Art starts with bread baked by us according to traditional recipes, amuse bouche from our Chef, and ends with selected wines from around the world.  Art Filipa 18 Food Wine Art is a place where tradition mixes with modernity. The graphics of young krakow artists from the Polish School of Posters give the restaurant a cozy and unique character.",
                    ImagePath = "/img/26228480.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 29,
                    Name = "Brasserie Olympique",
                    Description = "Chef Diana Olechnowicz invites you to a Brasserie Olympique at the Francuski Hotel, which has been a part of the history of Krakow since 1912. Brasserie's leitmotif is traditional and timeless classic French cuisine, experiencing splendor during the Belle Époque period. The culinary adventure begins with burgundy snails and ends with selected French wines and alcohols.",
                    ImagePath = "/img/28373802.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 30,
                    Name = "Cafe Stare Miasto",
                    Description = "Cafe Stare Miasto to urokliwe miejsce skryte w murach wiekowej kamienicy w samym centrum Krakowa - przy ulicy Gołębiej 2. Oferujemy między innymi tradycyjne śniadania, pyszną kawę oraz świeżo wyciskane soki. Cafe to miejsce, w którym możecie spotkać się z przyjaciółmi na kawę, przyjść z rodziną na kakao i gorącą czekoladę. Zjeść pożywne i smaczne śniadanie, orzeźwić się w upalne letnie dni, wypić regionalny browar ze znajomymi, a czasem głęboko patrzeć w oczy swojej drugiej połówki. To, że możemy być świadkami tych ważnych spotkań i wydarzeń daje nam satysfakcje i powera do pracy!:)",
                    ImagePath = "/img/29434123.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 31,
                    Name = "Cafe Botanica",
                    Description = "Cafe Botanica was opened in September 1997 and was - which is probably hard to believe today - the first and only cafe on Bracka Street. Our showcase is the huge, metal tree towering over the bar, which has become the most photographed tree in Krakow. Three different in character but stylishly uniform rooms with over 90 seats. Available for smokers - Orangery with a glass roof. Cafe Botanica is one of the most popular meeting places for students, an ideal idea for a quick meal as well as a romantic meeting in the center of the Old Town.",
                    ImagePath = "/img/34966448.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 32,
                    Name = "Platter by Karol Okrasa - InterContinental Warsaw",
                    Description = "The Executive Chef, Karol Okrasa, draws inspiration from his travels in Poland and around the world. From each region he visits, Okrasa carefully chooses unique products, spices and flavours, that all together compose an exceptional whole and create an excellent menu. A menu that delights with its singularity and delicacy. Platter cuisine combines modern forms and traditional ingredients.",
                    ImagePath = "/img/25688561.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 33,
                    Name = "WhoMoose Restaurant",
                    Description = "The best hummus in town... and wine!  Please, join us and experience the best hummus in town. We serve it with many additional ingredients on top. All vegetables or vegetarian. Additionally, test our deserts - every day we bake and make something new.",
                    ImagePath = "/img/27364832.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 34,
                    Name = "Brasserie Warszawska",
                    Description = "Come and try our menu inspired by the Warsaw and European cuisine blending simplicity and elegance of taste.",
                    ImagePath = "/img/28702711.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 35,
                    Name = "Garmasz Butcher & Restaurant",
                    Description = "GARMASZ cuisine is the result of many inspirations and two different culinary personalities. Piotr Pielichowski, the owner of the restaurant and its founder, who is passionate about good cuisine and young Head Chef - Dariusz Kucharski, who gained his experience in the famous, stars restaurants of London. The dishes served in GARMASZ Butcher & Restaurant are an original mixture of flavored compositions based on the highest quality products.  GARMASZ is a true shrine of the highest quality, here every foodie will find what he loves the most!  The interior of GARMASZ is equally unique and full of magic.  The project was created by the excellent Tri-city architect Krystian Rassmus. The unique climate is made of oak planks smoked in Austria, burnt tiles in stoves from the 18th century, crystal chandelier or alabaster on the walls. From this place, you just do not want to leave.",
                    ImagePath = "/img/26388079.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 36,
                    Name = "Na Lato",
                    Description = "Na Lato is a place located in the heart of Warsaw's Powiśle, where seasonal food is served all day, in the evening celebrates nightlife with wine and cocktails, and dances until the morning on the weekend.  A summer garden with deckchairs surrounded by the park, as well as an all-year winter garden create an atmosphere that has made Na Lato a favorite meeting and relaxation place.",
                    ImagePath = "/img/26596962.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 37,
                    Name = "Boathouse Restaurant",
                    Description = "On the banks of the Vistula river, in unforgettable surroundings lies one of the most beautiful located Warsaw restaurants- Boathouse. Even though it is a 10 minute drive from Downtown, sitting in our summer garden, surrounded with greenery, delecting Mediterranean dishes, you will understand why Boathouse is known as Warsaw's greatest escape. Boathouse has delicious Mediterranean dishes to offer with a strong presence of Italian cuisine. All guests are welcome to use our free-of-charge guarded cark park with parking spaces for over 70 cars.",
                    ImagePath = "/img/26387897.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 38,
                    Name = "Koneser Grill",
                    Description = "Koneser Grill is a place for lovers of food, barbecue, the highest quality product, good wine. Koneser Grill has an open kitchen in which we work on live fire. We want guests to be able to see the fire, feel its warmth, understand its unpredictability. Fire gives life, but it can also burn us. Working with fire is very demanding, and the chef working with him must have an extraordinary instinct to tame him.",
                    ImagePath = "/img/28035943.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 39,
                    Name = "Rada Miasta Food & Wine",
                    Description = "Rada Miasta – Food & Wine is the only winery in Gdańsk offering the largest selection of wines. In our huge Cellary we have over 360 types of wines from almost the whole Word. In our portfolio we have wines from France, Italy, Spain, Bulgaria and Poland. The microclimate and set temperature of our cellars guarantees a rich aroma and taste with each wineglass.  We know everything about wine, we will gladly help you choose the right wine to accompany your food, depending on the occasion and mood.",
                    ImagePath = "/img/28025473.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 40,
                    Name = "Chianti Grill Bar",
                    Description = "We have created a place full of unique atmosphere, Italian power and Tuscan flavors. A free concept of an open kitchen and a casual atmosphere can transfer you to the climate that once was present only in Italian cantinas. The menu includes a whole range of Tuscan and Italian specialties, and the richness of ingredients and original products is intimidated by the smell of herbs and spices. Our meals are unique in composition, prepared on the basis of recipes. All recipes are carefully collected by the owner and his family. We believe that for you, just like for us, it will be a unique and special place.",
                    ImagePath = "/img/29046328.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                },
                new Restaurant
                {
                    Id = 41,
                    Name = "Crudo",
                    Description = "CRUDO in Spanish means - raw. The interior of our restaurant best reflects this name – informal, yet designed with style and flare. Concrete, bare walls, wood and metal elements give this place a special ambiance with an ideal location in the heart of famous promenade of Monte Cassino. CRUDO in our restaurant has direct impact in the meals we serve. We've combined experience with passion to create unforgettable dining experience of highest quality. Our team is inspired by chef philosophy – Jan Nawrocki – from nose to tail – presenting our guests with unconventional style menu easy giving to temptation of simple yet savoring dishes. This culinary craftsmanship can be directly observed through the open kitchen environment where the state-of-the-art grill takes the center stage. Our special seasoning, handling and preparing food then frying it on this lava-stones grill gives meats and vegetables its unique aroma and flavor.",
                    ImagePath = "/img/28999410.jpg",
                    OpeningTimes = "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00",
                }
                );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Text = "Greek" },
                new Tag { Id = 2, Text = "Pizzeria" },
                new Tag { Id = 3, Text = "Vegetarian" },
                new Tag { Id = 4, Text = "Chinese" },
                new Tag { Id = 5, Text = "Vietnamese" }
                );

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 1, RestaurantId = 1, Name = "Item-R1-A", Price = 1.23M },
                new MenuItem { Id = 2,  RestaurantId = 1, Name = "Item-R1-B", Price = 1.23M },
                new MenuItem { Id = 3,  RestaurantId = 1, Name = "Item-R1-C", Price = 1.23M },
                new MenuItem { Id = 4,  RestaurantId = 1, Name = "Item-R1-D", Price = 1.23M },
                new MenuItem { Id = 5,  RestaurantId = 1, Name = "Item-R1-E", Price = 1.23M },
                new MenuItem { Id = 6,  RestaurantId = 1, Name = "Item-R1-F", Price = 1.23M },
                new MenuItem { Id = 7,  RestaurantId = 1, Name = "Item-R1-G", Price = 1.23M },
                new MenuItem { Id = 8, RestaurantId = 1, Name = "Item-R1-H", Price = 1.23M },

                new MenuItem {  Id = 9, RestaurantId = 2, Name = "Item-R2-A", Price = 10.23M },
                new MenuItem {  Id = 10, RestaurantId = 2, Name = "Item-R2-B", Price = 10.23M },
                new MenuItem {  Id = 11, RestaurantId = 2, Name = "Item-R2-C", Price = 10.23M },
                new MenuItem {  Id = 12, RestaurantId = 2, Name = "Item-R2-D", Price = 10.23M },
                new MenuItem {  Id = 13, RestaurantId = 2, Name = "Item-R2-E", Price = 10.23M },
                new MenuItem {  Id = 14, RestaurantId = 2, Name = "Item-R2-F", Price = 10.23M },
                new MenuItem {  Id = 15, RestaurantId = 2, Name = "Item-R2-G", Price = 10.23M },
                new MenuItem { Id = 16, RestaurantId = 2, Name = "Item-R2-H", Price = 10.23M },

                new MenuItem {  Id = 17, RestaurantId = 3, Name = "Item-R3-A", Price = 100.23M },
                new MenuItem {  Id = 18, RestaurantId = 3, Name = "Item-R3-B", Price = 100.23M },
                new MenuItem {  Id = 19, RestaurantId = 3, Name = "Item-R3-C", Price = 100.23M },
                new MenuItem {  Id = 20, RestaurantId = 3, Name = "Item-R3-D", Price = 100.23M },
                new MenuItem {  Id = 21, RestaurantId = 3, Name = "Item-R3-E", Price = 100.23M },
                new MenuItem {  Id = 22, RestaurantId = 3, Name = "Item-R3-F", Price = 100.23M },
                new MenuItem {  Id = 23, RestaurantId = 3, Name = "Item-R3-G", Price = 100.23M },
                new MenuItem { Id = 24, RestaurantId = 3, Name = "Item-R3-H", Price = 100.23M }
                );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, RestaurantId = 1, Author = "Arnold", Text = "It sucks!", Score = 1 },
                new Review { Id = 2, RestaurantId = 1, Author = "Bernard", Text = "Great place, would certainly eat at again.", Score = 5 },
                new Review { Id = 3, RestaurantId = 1, Author = "Ciril", Text = "If only they had more variety. The quality is decent but I got bored of their food already.", Score = 3 },
                new Review { Id = 4, RestaurantId = 1, Author = "Dionisius", Text = "Meh.", Score = 2 },
                new Review { Id = 5, RestaurantId = 1, Author = "Ergon", Text = "I love this place! <3", Score = 5 },
                new Review { Id = 6, RestaurantId = 1, Author = "Fred", Text = "Decent food. Pretty cheap too.", Score = 4 },

                new Review { Id = 7, RestaurantId = 2, Author = "Gregory", Text = "Just wonderful!", Score = 5 },
                new Review { Id = 8, RestaurantId = 2, Author = "Helga", Text = "I'm not saying that this place sells s***, but I wouldn't eat it again.", Score = 1 },
                new Review { Id = 9, RestaurantId = 2, Author = "Ian", Text = "Not great, not terrible", Score = 3 },
                new Review { Id = 10, RestaurantId = 2, Author = "Jeremy", Text = "Truly amazing place, never ate such good food", Score = 5 },
                new Review { Id = 11, RestaurantId = 2, Author = "Karol", Text = "I enjoyed every bit of it!", Score = 5 }

                
                );

            //modelBuilder.Entity<Table>().HasData(                );
            //modelBuilder.Entity<Booking>().HasData();

        }
    }
}
