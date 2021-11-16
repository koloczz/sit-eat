using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SitEat.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningTimes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    NumberOfSits = table.Column<int>(type: "int", nullable: false),
                    PositionX = table.Column<int>(type: "int", nullable: false),
                    PositionY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tables_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTag",
                columns: table => new
                {
                    RestaurantsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTag", x => new { x.RestaurantsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_RestaurantTag_Restaurants_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStart = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "OpeningTimes" },
                values: new object[,]
                {
                    { 1, "Located in the UNESCO World Heritage Market Square, next door to the most famous church in Poland, St. Mary’s Basilica, Hard Rock Krakow will inspire your taste buds to greatness with delicious food, signature cocktails, and the hottest live entertainment in Poland. With room for 130 guests over three spacious floors, our restaurant welcomes locals and tourists alike for delectable dining, top notch entertainment, and unforgettable events. After a delicious meal of American fare, take a stroll through musical history with iconic pieces of memorabilia you can only find at Hard Rock Cafe Krakow. Enjoy freshly prepared American cuisine and classic favorites like our Legendary Burger. From flavorful salads, to savory entrees, our chefs use only the freshest ingredients to create culinary perfection. Experience the difference of Hard Rock’s service with an energetic, hardworking staff, ready to provide you with everything you need to enjoy the perfect meal.", "/img/28088554.jpg", "Hard Rock Café - Kraków", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 25, "TOP GUN GRILL BAR GDANSK  Eat, Drink and Fly... High American Restaurant Słoneczna Morena", "/img/28985533.jpg", "TOP GUN Grill Bar", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 26, "The “Zagłębie Smaku” Restaurant is located on the first floor and is sure to impress you with its elegant interior design. International dishes served here have a regional flavour and will satisfy the most demanding palates. “Zaglebie Smaku” is a great place for a business lunch, a gala dinner or a Sunday brunch with friends and family.", "/img/25734955.jpg", "Zaglebie Smaku - Holiday Inn Dabrowa Gornicza", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 27, "Panorama Sky Bar is situated on the 40th floor from which our guests can enjoy breathtaking views of Warsaw. But our handcrafted cocktails and infused alcoholic beverages prepared with herbs are the main reasons why you should visit us. We guarantee unique taste sensations!  Panorama Sky Bar znajduje się na 40. piętrze, z którego nasi goście mogą podziwiać zapierające dech w piersiach widoki na Warszawę. Jednak to nasze ręcznie robione koktajle i alkohole infuzowane ziołami są głównym powodem, dla którego warto nas odwiedzić. Gwarantujemy wyjątkowe doznania smakowe!", "/img/26421988.jpg", "Panorama Sky Bar - Warsaw Marriott Hotel", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 28, "Filipa 18 Food Wine Art Restaurant  Food Chef Marcin Sołtys has created a menu inspired by traditional polish cuisine in a modern style and regional products from the oldest market in Krakow - Stary Kleparz. Each dish is created on our open kitchen.  Wine Culinary adventure in Filipa 18 Food Wine Art starts with bread baked by us according to traditional recipes, amuse bouche from our Chef, and ends with selected wines from around the world.  Art Filipa 18 Food Wine Art is a place where tradition mixes with modernity. The graphics of young krakow artists from the Polish School of Posters give the restaurant a cozy and unique character.", "/img/26228480.jpg", "Filipa 18 Food Wine Art - Indigo Krakow", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 29, "Chef Diana Olechnowicz invites you to a Brasserie Olympique at the Francuski Hotel, which has been a part of the history of Krakow since 1912. Brasserie's leitmotif is traditional and timeless classic French cuisine, experiencing splendor during the Belle Époque period. The culinary adventure begins with burgundy snails and ends with selected French wines and alcohols.", "/img/28373802.jpg", "Brasserie Olympique", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 30, "Cafe Stare Miasto to urokliwe miejsce skryte w murach wiekowej kamienicy w samym centrum Krakowa - przy ulicy Gołębiej 2. Oferujemy między innymi tradycyjne śniadania, pyszną kawę oraz świeżo wyciskane soki. Cafe to miejsce, w którym możecie spotkać się z przyjaciółmi na kawę, przyjść z rodziną na kakao i gorącą czekoladę. Zjeść pożywne i smaczne śniadanie, orzeźwić się w upalne letnie dni, wypić regionalny browar ze znajomymi, a czasem głęboko patrzeć w oczy swojej drugiej połówki. To, że możemy być świadkami tych ważnych spotkań i wydarzeń daje nam satysfakcje i powera do pracy!:)", "/img/29434123.jpg", "Cafe Stare Miasto", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 31, "Cafe Botanica was opened in September 1997 and was - which is probably hard to believe today - the first and only cafe on Bracka Street. Our showcase is the huge, metal tree towering over the bar, which has become the most photographed tree in Krakow. Three different in character but stylishly uniform rooms with over 90 seats. Available for smokers - Orangery with a glass roof. Cafe Botanica is one of the most popular meeting places for students, an ideal idea for a quick meal as well as a romantic meeting in the center of the Old Town.", "/img/34966448.jpg", "Cafe Botanica", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 32, "The Executive Chef, Karol Okrasa, draws inspiration from his travels in Poland and around the world. From each region he visits, Okrasa carefully chooses unique products, spices and flavours, that all together compose an exceptional whole and create an excellent menu. A menu that delights with its singularity and delicacy. Platter cuisine combines modern forms and traditional ingredients.", "/img/25688561.jpg", "Platter by Karol Okrasa - InterContinental Warsaw", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 33, "The best hummus in town... and wine!  Please, join us and experience the best hummus in town. We serve it with many additional ingredients on top. All vegetables or vegetarian. Additionally, test our deserts - every day we bake and make something new.", "/img/27364832.jpg", "WhoMoose Restaurant", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 34, "Come and try our menu inspired by the Warsaw and European cuisine blending simplicity and elegance of taste.", "/img/28702711.jpg", "Brasserie Warszawska", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 35, "GARMASZ cuisine is the result of many inspirations and two different culinary personalities. Piotr Pielichowski, the owner of the restaurant and its founder, who is passionate about good cuisine and young Head Chef - Dariusz Kucharski, who gained his experience in the famous, stars restaurants of London. The dishes served in GARMASZ Butcher & Restaurant are an original mixture of flavored compositions based on the highest quality products.  GARMASZ is a true shrine of the highest quality, here every foodie will find what he loves the most!  The interior of GARMASZ is equally unique and full of magic.  The project was created by the excellent Tri-city architect Krystian Rassmus. The unique climate is made of oak planks smoked in Austria, burnt tiles in stoves from the 18th century, crystal chandelier or alabaster on the walls. From this place, you just do not want to leave.", "/img/26388079.jpg", "Garmasz Butcher & Restaurant", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 36, "Na Lato is a place located in the heart of Warsaw's Powiśle, where seasonal food is served all day, in the evening celebrates nightlife with wine and cocktails, and dances until the morning on the weekend.  A summer garden with deckchairs surrounded by the park, as well as an all-year winter garden create an atmosphere that has made Na Lato a favorite meeting and relaxation place.", "/img/26596962.jpg", "Na Lato", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 37, "On the banks of the Vistula river, in unforgettable surroundings lies one of the most beautiful located Warsaw restaurants- Boathouse. Even though it is a 10 minute drive from Downtown, sitting in our summer garden, surrounded with greenery, delecting Mediterranean dishes, you will understand why Boathouse is known as Warsaw's greatest escape. Boathouse has delicious Mediterranean dishes to offer with a strong presence of Italian cuisine. All guests are welcome to use our free-of-charge guarded cark park with parking spaces for over 70 cars.", "/img/26387897.jpg", "Boathouse Restaurant", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 38, "Koneser Grill is a place for lovers of food, barbecue, the highest quality product, good wine. Koneser Grill has an open kitchen in which we work on live fire. We want guests to be able to see the fire, feel its warmth, understand its unpredictability. Fire gives life, but it can also burn us. Working with fire is very demanding, and the chef working with him must have an extraordinary instinct to tame him.", "/img/28035943.jpg", "Koneser Grill", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 39, "Rada Miasta – Food & Wine is the only winery in Gdańsk offering the largest selection of wines. In our huge Cellary we have over 360 types of wines from almost the whole Word. In our portfolio we have wines from France, Italy, Spain, Bulgaria and Poland. The microclimate and set temperature of our cellars guarantees a rich aroma and taste with each wineglass.  We know everything about wine, we will gladly help you choose the right wine to accompany your food, depending on the occasion and mood.", "/img/28025473.jpg", "Rada Miasta Food & Wine", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 40, "We have created a place full of unique atmosphere, Italian power and Tuscan flavors. A free concept of an open kitchen and a casual atmosphere can transfer you to the climate that once was present only in Italian cantinas. The menu includes a whole range of Tuscan and Italian specialties, and the richness of ingredients and original products is intimidated by the smell of herbs and spices. Our meals are unique in composition, prepared on the basis of recipes. All recipes are carefully collected by the owner and his family. We believe that for you, just like for us, it will be a unique and special place.", "/img/29046328.jpg", "Chianti Grill Bar", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 41, "CRUDO in Spanish means - raw. The interior of our restaurant best reflects this name – informal, yet designed with style and flare. Concrete, bare walls, wood and metal elements give this place a special ambiance with an ideal location in the heart of famous promenade of Monte Cassino. CRUDO in our restaurant has direct impact in the meals we serve. We've combined experience with passion to create unforgettable dining experience of highest quality. Our team is inspired by chef philosophy – Jan Nawrocki – from nose to tail – presenting our guests with unconventional style menu easy giving to temptation of simple yet savoring dishes. This culinary craftsmanship can be directly observed through the open kitchen environment where the state-of-the-art grill takes the center stage. Our special seasoning, handling and preparing food then frying it on this lava-stones grill gives meats and vegetables its unique aroma and flavor.", "/img/28999410.jpg", "Crudo", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 24, "Modern and stylish interior, bustling surroundings and outstanding thai cuisine are the main reasons for the restaurants impressive popularity amongst both tourists and locals. Close proximity of the sea make our seafood-based dishes higly popular.", "/img/27039418.jpg", "Thai Thai Sopot", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 22, "The name of our restaurant, Mercato, signifies the trade route of Pomerania – via Mercatorum, which historically connected Gdańsk with Southern Poland. Our menu combines local and seasonal products with culinary trends from around the world, using the latest techniques. The four symbols which inspire our menu are rooted in history – the broad bean grain, planted by the Pomeranians in e, the noble Baltic salmon, the ‘Fagas’ which was a large Pomeranian sheep bred on Zulawy, and finally the duck, used as a symbol of birds bred for centuries in Pomerania.", "/img/28220201.jpg", "Mercato - Hilton Gdansk", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 23, "Eliksir is a unique place in Tri-City – it is a combination of restaurant, cocktail bar and event space. The keynote in Eliksir is foodpairing, so the art of combining flavors.", "/img/28023560.jpg", "Eliksir", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 20, "Hotel Rysy restaurant serves tasty Polish specialties in the heart of Zakopane. We are only a few steps from Krupówki. Our menu includes gluten-free and vegetarian options. Rysy is the highest peak in Polish Tatras and in our dishes we use the highest quality local products. Smacznego !", "/img/42413778.jpg", "Hotel Rysy", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 2, "Hard Rock Cafe Wrocław is a spacious, state-of-the-art property that boasts a contemporary restaurant with a stage, two modern bars, and a retail store. Conveniently located 13 kilometers from the airport, it’s the perfect place to stop and grab a bite before exploring this diverse Polish city. Hard Rock Cafe Wrocław features two floors decorated with our signature contemporary design, including music memorabilia from top international and local artists. Guests can sit down and enjoy the rock n’ roll history all over the walls while taking a bite of one of our savory dishes, like the Local Legendary® Burger, which is unique to our Wrocław cafe. After your meal, you can even visit our Rock Shop® to pick up a souvenir of your experience.", "/img/30641059.jpg", "Hard Rock Cafe - Wroclaw", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 3, "Nolita Restaurant was opened in November 2012, Internationally awarded Chef Jacek Grochowina has named his culinary venture based on Manhattan’s inspiring neighborhood were traditions and modernity have come together. His culinary philosophy is never stop learning. His style is based on creative interpretation of modern French cuisine using polish seasonal ingredients, also loves to put some oriental twist in his dishes. From the very beginning restaurant was planned to be fine dining informal style with only 40 seats and fully open kitchen all the guests can follow the preparation of the dishes.", "/img/26042070.jpg", "Nolita Restaurant", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 4, "Hard Rock Cafe is located in an exclusive Złote Tarasy shopping center in the very heart of the city close to Main Central Railway Station. The restaurant is famous for American cuisine for meat lovers and vegetarians, an extensive cocktails menu and breakfast & lunch special offers. Guests can enjoy live music surrounded by nearly 300 original memorabilia of legendary artists and choose from a variety of clothes, accessories and collectible pins with Hard Rock Cafe logo   Hard Rock Cafe zlokalizowany jest w samym sercu stolicy, przy Centrum Handlowym Złote Tarasy oraz w pobliżu dworca kolejowego Warszawa Centralna. Restauracja słynie z amerykańskiej kuchni i bogatego wyboru koktajli. W swojej ofercie ma również kartę śniadań i lunchów, dania dla wegetarian oraz menu dla dzieci. Goście mogą posłuchać muzyki na żywo w otoczeniu prawie 300 oryginalnych pamiątek muzycznych. Hard Rock Cafe to także sklep z ubraniami, akcesoriami i kolekcjonerskimi pinami z legendarnym logo", "/img/26467404.jpg", "Hard Rock Cafe - Warsaw", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 5, "Dyletanci focuses on the product. We want to interpret, not change.  We think of food as a multi-layered experience. We want this experience to be stimulating through its quality, taste, and balance. To us the product and it's needs mean the top quality ingredients, our crops, and farms, as well as understanding the place where we live.  Dyletanci is also the most special wine list in Poland. Over 1,400 items, mostly from biodynamic wineries. The producers who stand behind these wines are people who respect the land and its products and in wine seek purity, energy, and emotions. In addition to the cuisine and wine, we focus on decor elements consistent with our thinking about the place - Zalto light glasseware, hand-made ceramics, and works by Polish graphic designers.  Our commitment and attachment to details build the soul of the place where we want our guests to feel comfortable, to feel good.  We, the Dilettantes.", "/img/27614372.jpg", "Dyletanci", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 6, "Restaurant Concept 13 is located on the 5th floor of DH VITKAC. Its large, glassed interior looks out on a beautiful panorama of the capital which can also be enjoyed from the summer terrace. The dishes are international classics with a polish twist partly prepared on teppanyaki grills or in the open kitchen. The uniqueness of our cuisine is based on experience and innovation in food creation as well as on the dedication deriving of the culinary passion of our Chefs. In summer we invite our guests to the terrace. Every weekend from 12.00 to 18.00 we invite Your children to visit a special children’s corner. Our professional babysitters will keep an eye on Your kids.", "/img/43619261.jpg", "Concept13", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 7, "According to the Japanese tradition, sushi is a combination of carefully cooked rice and fresh, tasty ingredients. At Youmiko we serve 100% vegan sushi taking you on a journey to discover the richness and diversity of the plant world.  We source our vegetables both from the local farmers and most exotic places.  Our aim is to mix traditional Japanese approach and Polish creativity to surprise you with new flavours and textures. To ensure the best taste and temperature we always serve our sushi to your table in portions just after preparing it.  We never specify sushi ingredients in our menu as they depend on the availability of fresh vegetables and the creativity of our Sushi Masters. Ask us what we are serving today!  Upon request, we can prepare gluten-free sushi. Please inform us about your food allergies when ordering.", "/img/28326270.jpg", "Youmiko Vegan Sushi Centrum", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 8, "Champions Sports Bar & Restaurant is a great place to cater to sports fans. Enjoy great food while cheering on your favorite team! Experience the sports excitement with us! Our concept is simple: GOOD FOOD Delicious American snacks complemented by a wide choice of spirits and national and international beers. GOOD SPORT Broadcasting of major sporting events on 37 TVs and 2 large projection screens. GOOD TIME An excellent spot to relax among friends and cheer on your favorite sports teams.  Champions Sports Bar Restaurant to bar dla fanów sportu. Ciesz się wspaniałym jedzeniem, kibicując ulubionej drużynie! Przeżyj z nami sportowe emocje! Nasza koncepcja jest prosta: DOBRE JEDZENIE Pyszne amerykańskie przekąski uzupełnione szerokim wyborem alkoholi oraz piw krajowych i międzynarodowych. SPORT Nadawanie najważniejszych wydarzeń sportowych na 37 telewizorach i 2 dużych ekranach projekcyjnych. MIŁO SPĘDZONY CZAS Doskonałe miejsce na relaks z przyjaciółmi i kibicowanie ulubionym drużynom", "/img/26773424.jpg", "Champions Sports Bar & Restaurant", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 21, "The 'Thai Thai' concept consists of four unique locations, visibly connected by authentic cuisine and modern, but fully thai-inspired interior. The exceptional ambiance of the Gdańsk location is the result of merging a modern thai-inspired decoration with monumental brick walls, remainants of four-hundred year old city fortifications. Outstanding, but authentic dishes, top quality ingridients from around the globe, extremely talented head chef, and a crew of meticulously chosen cooks, from the finest restaurants in his country of origin. Thailand was never closer.", "/img/26469506.jpg", "Thai Thai Gdańsk", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 10, "'Life is too short to drink bad wine' - these famous words by the great German poet, Goethe, summarise our passion and served as an inspiration for creating our wine bar and shop in Warsaw. Together with an exceptional menu designed by the chef Paweł Rosiński, our wines create a truly unmissable pair! Czarne Czerwone Zlote was born out of our great passion for wines and even greater passion for people. We want to encourage celebration of moments - not only those special and important ones but also the usually underapprieciated casual ones. Being located in the centre of Warsaw, our bar is easily accessible while remaining a quiet retreat to enjoy the best wines and outstanding food thanks to the surroundings of old, historic buildings. The friendly and climatic ambience of our venue is enhanced by original brick walls and use of natural materials, wood and rock. Immerse yourself in our warm atmosphere and feel the magic of German wines.", "/img/43431959.jpg", "Czarne Czerwone Zlote Restauracja & Wine Bar", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 9, "The concept consists of four locations. Each one is different and unique, but they are visibly connected by authentic cuisine, modern, but fully thai-inspired interior and this special ambiance. Outstanding, but authentic dishes, top quality ingridients from around the globe, extremely talented head chef, and a crew of meticulously chosen cooks, from the finest restaurants in his country of origin. Thailand was never closer.", "/img/26728785.jpg", "Thai Thai Warszawa", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 12, "Fresh oysters or lobster’s delicate meat? Each decision will be the best one – because each decision is tasty. You don’t have to wait until Thursday – we have an oyster tank and a lobster tank. Our restaurant has the pleasure of serving you fresh seafood seven days a week. To go with the meal you can choose from a wide array of wines and Champagne, among which you can find unique, vintage wines from the world’s best producers.", "/img/27272218.jpg", "L'arc Varsovie", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 13, "Former military barrack complex raised around 1905 has been recently renovated and adapted for new functions, becoming a self-styled culinary heart of Poznań. Amongst many restaurant concepts within the City Park, you may find the newest Thai Thai restaurant with a modern, polished interior, beautifully contrasting with the historical form of the building. It is also worth mentioning the impressive open kitchen, wide offer of premium wines and spirits and top-class authentic Thai cuisine -all the necessary elements for an unforgettable oriental voyage.", "/img/26728801.jpg", "Thai Thai Poznan", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 14, "We take great pride in the best polish produce and culinary traditions, serving beautiful, authentic food which we all associate with comfort and a warm welcome, alongside a great selection of craft beer, wine and cocktails.", "/img/26794429.jpg", "Rynek Restaurant - Sheraton Poznan Hotel", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 15, "Located in the very heart of Warsaw, Floor No 2 Restaurant with unique view of the city skyline offers a contemporary a breakfast venue and regular restaurant with Mediterranean cuisine for launch and dinners. Besides the restaurant Floor No 2 focus on individual, personalized service and unique atmosphere that is perfectly suitable for meetings, lunches, dinners and corporate parties - you name it, we can do it! Also, we have private dining spaces, suitable for parties or meeting of up to 20 seated guests.", "/img/28916235.jpg", "Floor No 2 restaurant - Warsaw Marriott Hotel", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 16, "According to the Japanese tradition, sushi is a combination of carefully cooked rice and fresh, tasty ingredients. At Youmiko we serve 100% vegan sushi taking you on a journey to discover the richness and diversity of the plant world.  We source our vegetables both from the local farmers and most exotic places.  Our aim is to mix traditional Japanese approach and Polish creativity to surprise you with new flavours and textures. To ensure the best taste and temperature we always serve our sushi to your table in portions just after preparing it.  We never specify sushi ingredients in our menu as they depend on the availability of fresh vegetables and the creativity of our Sushi Masters. Ask us what we are serving today!  Upon request, we can prepare gluten-free sushi. Please inform us about your food allergies when ordering.", "/img/30414287.jpg", "Youmiko Vegan Sushi Mokotow", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 17, "Les Amis French restaurant in Warsaw, Poland Flam & Biere", "/img/27936997.jpg", "Les Amis", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 18, "Experience authentic dining and world class entertainment when you visit Hard Rock Cafe Gdansk. With room for 100 guests, our spacious restaurant and lounge boasts two floors, a modern bar, and a large outdoor patio area. We are located in heart of Gdansk, on Długi Targ Street, between the magnificent four-arched Green Gate gatehouse—built as a palace for Polish monarchs—and Neptune Fountain, the most memorable fountain in Poland and one of the defining symbols of Gdansk. After a delicious meal of delectable American fare, take a stroll through musical history with an extensive collection of musical memorabilia you can only find at Hard Rock Cafe Gdansk.", "/img/28105968.jpg", "Hard Rock Cafe - Gdansk", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 19, "Lorem ipsum", "/img/28029123.jpg", "Romantyczna Restauracja", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" },
                    { 11, "", "/img/26468459.jpg", "Enoteka Warszawska", "Mon - Fri: 7:00 - 22:00<br>Sat - Sun: 12:00 - 24:00" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[] { 4, "Chinese" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Greek" },
                    { 2, "Pizzeria" },
                    { 3, "Vegetarian" },
                    { 5, "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Item-R1-A", 1.23m, 1 },
                    { 22, "Item-R3-F", 100.23m, 3 },
                    { 21, "Item-R3-E", 100.23m, 3 },
                    { 20, "Item-R3-D", 100.23m, 3 },
                    { 19, "Item-R3-C", 100.23m, 3 },
                    { 18, "Item-R3-B", 100.23m, 3 },
                    { 17, "Item-R3-A", 100.23m, 3 },
                    { 16, "Item-R2-H", 10.23m, 2 },
                    { 15, "Item-R2-G", 10.23m, 2 },
                    { 14, "Item-R2-F", 10.23m, 2 },
                    { 13, "Item-R2-E", 10.23m, 2 },
                    { 23, "Item-R3-G", 100.23m, 3 },
                    { 11, "Item-R2-C", 10.23m, 2 },
                    { 10, "Item-R2-B", 10.23m, 2 },
                    { 12, "Item-R2-D", 10.23m, 2 },
                    { 24, "Item-R3-H", 100.23m, 3 },
                    { 2, "Item-R1-B", 1.23m, 1 },
                    { 3, "Item-R1-C", 1.23m, 1 },
                    { 4, "Item-R1-D", 1.23m, 1 },
                    { 5, "Item-R1-E", 1.23m, 1 },
                    { 6, "Item-R1-F", 1.23m, 1 },
                    { 8, "Item-R1-H", 1.23m, 1 },
                    { 7, "Item-R1-G", 1.23m, 1 },
                    { 9, "Item-R2-A", 10.23m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Author", "RestaurantId", "Score", "Text" },
                values: new object[,]
                {
                    { 11, "Karol", 2, 5, "I enjoyed every bit of it!" },
                    { 9, "Ian", 2, 3, "Not great, not terrible" },
                    { 8, "Helga", 2, 1, "I'm not saying that this place sells s***, but I wouldn't eat it again." },
                    { 7, "Gregory", 2, 5, "Just wonderful!" },
                    { 1, "Arnold", 1, 1, "It sucks!" },
                    { 2, "Bernard", 1, 5, "Great place, would certainly eat at again." },
                    { 3, "Ciril", 1, 3, "If only they had more variety. The quality is decent but I got bored of their food already." },
                    { 4, "Dionisius", 1, 2, "Meh." },
                    { 5, "Ergon", 1, 5, "I love this place! <3" },
                    { 10, "Jeremy", 2, 5, "Truly amazing place, never ate such good food" },
                    { 6, "Fred", 1, 4, "Decent food. Pretty cheap too." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TableId",
                table: "Bookings",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_RestaurantId",
                table: "MenuItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTag_TagsId",
                table: "RestaurantTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_RestaurantId",
                table: "Tables",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "RestaurantTag");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
