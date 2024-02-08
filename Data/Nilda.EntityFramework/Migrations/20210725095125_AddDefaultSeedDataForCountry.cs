using Microsoft.EntityFrameworkCore.Migrations;

namespace Nilda.EntityFrameworkCore.Migrations
{
    public partial class AddDefaultSeedDataForCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "isActive", "isDefault" },
                values: new object[,]
                {
                    { 2, "BD", "Bangladesh", false, false },
                    { 160, "CY", "Cyprus", false, false },
                    { 161, "CX", "Christmas Island", false, false },
                    { 162, "CR", "Costa Rica", false, false },
                    { 163, "CW", "Curacao", false, false },
                    { 164, "CV", "Cape Verde", false, false },
                    { 165, "CU", "Cuba", false, false },
                    { 166, "SZ", "Swaziland", false, false },
                    { 167, "SY", "Syria", false, false },
                    { 168, "SX", "Sint Maarten", false, false },
                    { 169, "KG", "Kyrgyzstan", false, false },
                    { 170, "KE", "Kenya", false, false },
                    { 171, "SS", "South Sudan", false, false },
                    { 172, "SR", "Suriname", false, false },
                    { 173, "KI", "Kiribati", false, false },
                    { 174, "KH", "Cambodia", false, false },
                    { 175, "KN", "Saint Kitts and Nevis", false, false },
                    { 176, "KM", "Comoros", false, false },
                    { 177, "ST", "Sao Tome and Principe", false, false },
                    { 178, "SK", "Slovakia", false, false },
                    { 179, "KR", "South Korea", false, false },
                    { 180, "SI", "Slovenia", false, false },
                    { 181, "KP", "North Korea", false, false },
                    { 182, "KW", "Kuwait", false, false },
                    { 183, "SN", "Senegal", false, false },
                    { 184, "SM", "San Marino", false, false },
                    { 185, "SL", "Sierra Leone", false, false },
                    { 186, "SC", "Seychelles", false, false },
                    { 159, "CZ", "Czech Republic", false, false },
                    { 187, "KZ", "Kazakhstan", false, false },
                    { 158, "CD", "Democratic Republic of the Congo", false, false },
                    { 156, "CG", "Republic of the Congo", false, false },
                    { 129, "FJ", "Fiji", false, false },
                    { 130, "FK", "Falkland Islands", false, false },
                    { 131, "FM", "Micronesia", false, false },
                    { 132, "FO", "Faroe Islands", false, false },
                    { 133, "NI", "Nicaragua", false, false },
                    { 134, "NL", "Netherlands", false, false },
                    { 135, "NO", "Norway", false, false },
                    { 136, "NA", "Namibia", false, false },
                    { 137, "VU", "Vanuatu", false, false },
                    { 138, "NC", "New Caledonia", false, false }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "isActive", "isDefault" },
                values: new object[,]
                {
                    { 139, "NE", "Niger", false, false },
                    { 140, "NF", "Norfolk Island", false, false },
                    { 141, "NG", "Nigeria", false, false },
                    { 142, "NZ", "New Zealand", false, false },
                    { 143, "NP", "Nepal", false, false },
                    { 144, "NR", "Nauru", false, false },
                    { 145, "NU", "Niue", false, false },
                    { 146, "CK", "Cook Islands", false, false },
                    { 147, "XK", "Kosovo", false, false },
                    { 148, "CI", "Ivory Coast", false, false },
                    { 149, "CH", "Switzerland", false, false },
                    { 150, "CO", "Colombia", false, false },
                    { 151, "CN", "China", false, false },
                    { 152, "CM", "Cameroon", false, false },
                    { 153, "CL", "Chile", false, false },
                    { 154, "CC", "Cocos Islands", false, false },
                    { 155, "CA", "Canada", false, false },
                    { 157, "CF", "Central African Republic", false, false },
                    { 188, "KY", "Cayman Islands", false, false },
                    { 189, "SG", "Singapore", false, false },
                    { 190, "SE", "Sweden", false, false },
                    { 223, "TC", "Turks and Caicos Islands", false, false },
                    { 224, "LY", "Libya", false, false },
                    { 225, "VA", "Vatican", false, false },
                    { 226, "VC", "Saint Vincent and the Grenadines", false, false },
                    { 227, "AE", "United Arab Emirates", false, false },
                    { 228, "AD", "Andorra", false, false },
                    { 229, "AG", "Antigua and Barbuda", false, false },
                    { 230, "AF", "Afghanistan", false, false },
                    { 231, "AI", "Anguilla", false, false },
                    { 232, "VI", "U.S. Virgin Islands", false, false },
                    { 233, "IS", "Iceland", false, false },
                    { 234, "IR", "Iran", false, false },
                    { 235, "AM", "Armenia", false, false },
                    { 236, "AL", "Albania", false, false },
                    { 237, "AO", "Angola", false, false },
                    { 238, "AQ", "Antarctica", false, false },
                    { 239, "AS", "American Samoa", false, false },
                    { 240, "AR", "Argentina", false, false },
                    { 241, "AU", "Australia", false, false },
                    { 242, "AT", "Austria", false, false },
                    { 243, "AW", "Aruba", false, false }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "isActive", "isDefault" },
                values: new object[,]
                {
                    { 244, "IN", "India", false, false },
                    { 245, "AX", "Aland Islands", false, false },
                    { 246, "AZ", "Azerbaijan", false, false },
                    { 247, "IE", "Ireland", false, false },
                    { 248, "ID", "Indonesia", false, false },
                    { 249, "UA", "Ukraine", false, false },
                    { 222, "TD", "Chad", false, false },
                    { 221, "TG", "Togo", false, false },
                    { 220, "TF", "French Southern Territories", false, false },
                    { 219, "TH", "Thailand", false, false },
                    { 191, "SD", "Sudan", false, false },
                    { 192, "DO", "Dominican Republic", false, false },
                    { 193, "DM", "Dominica", false, false },
                    { 194, "DJ", "Djibouti", false, false },
                    { 195, "DK", "Denmark", false, false },
                    { 196, "VG", "British Virgin Islands", false, false },
                    { 197, "DE", "Germany", false, false },
                    { 198, "YE", "Yemen", false, false },
                    { 199, "DZ", "Algeria", false, false },
                    { 200, "US", "United States", false, false },
                    { 201, "UY", "Uruguay", false, false },
                    { 202, "YT", "Mayotte", false, false },
                    { 203, "UM", "United States Minor Outlying Islands", false, false },
                    { 128, "FI", "Finland", false, false },
                    { 204, "LB", "Lebanon", false, false },
                    { 206, "LA", "Laos", false, false },
                    { 207, "TV", "Tuvalu", false, false },
                    { 208, "TW", "Taiwan", false, false },
                    { 209, "TT", "Trinidad and Tobago", false, false },
                    { 210, "TR", "Turkey", false, false },
                    { 211, "LK", "Sri Lanka", false, false },
                    { 212, "LI", "Liechtenstein", false, false },
                    { 213, "LV", "Latvia", false, false },
                    { 214, "TO", "Tonga", false, false },
                    { 215, "LT", "Lithuania", false, false },
                    { 216, "LU", "Luxembourg", false, false },
                    { 217, "LR", "Liberia", false, false },
                    { 218, "LS", "Lesotho", false, false },
                    { 205, "LC", "Saint Lucia", false, false },
                    { 127, "SH", "Saint Helena", false, false },
                    { 126, "IO", "British Indian Ocean Territory", false, false },
                    { 125, "FR", "France", false, false }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "isActive", "isDefault" },
                values: new object[,]
                {
                    { 35, "TK", "Tokelau", false, false },
                    { 36, "GW", "Guinea-Bissau", false, false },
                    { 37, "GU", "Guam", false, false },
                    { 38, "GT", "Guatemala", false, false },
                    { 39, "GS", "South Georgia and the South Sandwich Islands", false, false },
                    { 40, "GR", "Greece", false, false },
                    { 41, "GQ", "Equatorial Guinea", false, false },
                    { 42, "GP", "Guadeloupe", false, false },
                    { 43, "JP", "Japan", false, false },
                    { 44, "GY", "Guyana", false, false },
                    { 45, "GG", "Guernsey", false, false },
                    { 46, "GF", "French Guiana", false, false },
                    { 47, "GE", "Georgia", false, false },
                    { 48, "GD", "Grenada", false, false },
                    { 49, "GB", "United Kingdom", false, false },
                    { 50, "GA", "Gabon", false, false },
                    { 51, "SV", "El Salvador", false, false },
                    { 52, "GN", "Guinea", false, false },
                    { 53, "GM", "Gambia", false, false },
                    { 54, "GL", "Greenland", false, false },
                    { 55, "GI", "Gibraltar", false, false },
                    { 56, "GH", "Ghana", false, false },
                    { 57, "OM", "Oman", false, false },
                    { 58, "TN", "Tunisia", false, false },
                    { 59, "JO", "Jordan", false, false },
                    { 60, "HR", "Croatia", false, false },
                    { 61, "HT", "Haiti", false, false },
                    { 34, "RO", "Romania", false, false },
                    { 33, "TJ", "Tajikistan", false, false },
                    { 32, "TM", "Turkmenistan", false, false },
                    { 31, "RE", "Reunion", false, false },
                    { 3, "BE", "Belgium", false, false },
                    { 4, "BF", "Burkina Faso", false, false },
                    { 5, "BG", "Bulgaria", false, false },
                    { 6, "BA", "Bosnia and Herzegovina", false, false },
                    { 7, "BB", "Barbados", false, false },
                    { 8, "WF", "Wallis and Futuna", false, false },
                    { 9, "BL", "Saint Barthelemy", false, false },
                    { 10, "BM", "Bermuda", false, false },
                    { 11, "BN", "Brunei", false, false },
                    { 12, "BO", "Bolivia", false, false },
                    { 13, "BH", "Bahrain", false, false }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "isActive", "isDefault" },
                values: new object[,]
                {
                    { 14, "BI", "Burundi", false, false },
                    { 15, "BJ", "Benin", false, false },
                    { 62, "HU", "Hungary", false, false },
                    { 16, "BT", "Bhutan", false, false },
                    { 18, "BV", "Bouvet Island", false, false },
                    { 19, "BW", "Botswana", false, false },
                    { 20, "WS", "Samoa", false, false },
                    { 21, "BQ", "Bonaire, Saint Eustatius and Saba ", false, false },
                    { 22, "BR", "Brazil", false, false },
                    { 23, "BS", "Bahamas", false, false },
                    { 24, "JE", "Jersey", false, false },
                    { 25, "BY", "Belarus", false, false },
                    { 26, "BZ", "Belize", false, false },
                    { 27, "RU", "Russia", false, false },
                    { 28, "RW", "Rwanda", false, false },
                    { 29, "RS", "Serbia", false, false },
                    { 30, "TL", "East Timor", false, false },
                    { 17, "JM", "Jamaica", false, false },
                    { 250, "QA", "Qatar", false, false },
                    { 63, "HK", "Hong Kong", false, false },
                    { 65, "HM", "Heard Island and McDonald Islands", false, false },
                    { 98, "ME", "Montenegro", false, false },
                    { 99, "MD", "Moldova", false, false },
                    { 100, "MG", "Madagascar", false, false },
                    { 101, "MF", "Saint Martin", false, false },
                    { 102, "MA", "Morocco", false, false },
                    { 103, "MC", "Monaco", false, false },
                    { 104, "UZ", "Uzbekistan", false, false },
                    { 105, "MM", "Myanmar", false, false },
                    { 106, "ML", "Mali", false, false },
                    { 107, "MO", "Macao", false, false },
                    { 108, "MN", "Mongolia", false, false },
                    { 109, "MH", "Marshall Islands", false, false },
                    { 110, "MK", "Macedonia", false, false },
                    { 111, "MU", "Mauritius", false, false },
                    { 112, "MT", "Malta", false, false },
                    { 113, "MW", "Malawi", false, false },
                    { 114, "MV", "Maldives", false, false },
                    { 115, "MQ", "Martinique", false, false },
                    { 116, "MP", "Northern Mariana Islands", false, false },
                    { 117, "MS", "Montserrat", false, false },
                    { 118, "MR", "Mauritania", false, false }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "isActive", "isDefault" },
                values: new object[,]
                {
                    { 119, "IM", "Isle of Man", false, false },
                    { 120, "UG", "Uganda", false, false },
                    { 121, "TZ", "Tanzania", false, false },
                    { 122, "MY", "Malaysia", false, false },
                    { 123, "MX", "Mexico", false, false },
                    { 124, "IL", "Israel", false, false },
                    { 97, "ER", "Eritrea", false, false },
                    { 96, "ES", "Spain", false, false },
                    { 95, "SA", "Saudi Arabia", false, false },
                    { 94, "ZW", "Zimbabwe", false, false },
                    { 66, "VE", "Venezuela", false, false },
                    { 67, "PR", "Puerto Rico", false, false },
                    { 68, "PS", "Palestinian Territory", false, false },
                    { 69, "PW", "Palau", false, false },
                    { 70, "PT", "Portugal", false, false },
                    { 71, "SJ", "Svalbard and Jan Mayen", false, false },
                    { 72, "PY", "Paraguay", false, false },
                    { 73, "IQ", "Iraq", false, false },
                    { 74, "PA", "Panama", false, false },
                    { 75, "PF", "French Polynesia", false, false },
                    { 76, "PG", "Papua New Guinea", false, false },
                    { 77, "PE", "Peru", false, false },
                    { 78, "PK", "Pakistan", false, false },
                    { 64, "HN", "Honduras", false, false },
                    { 79, "PH", "Philippines", false, false },
                    { 81, "PL", "Poland", false, false },
                    { 82, "PM", "Saint Pierre and Miquelon", false, false },
                    { 83, "ZM", "Zambia", false, false },
                    { 84, "EH", "Western Sahara", false, false },
                    { 85, "EE", "Estonia", false, false },
                    { 86, "EG", "Egypt", false, false },
                    { 87, "ZA", "South Africa", false, false },
                    { 88, "EC", "Ecuador", false, false },
                    { 89, "IT", "Italy", false, false },
                    { 90, "VN", "Vietnam", false, false },
                    { 91, "SB", "Solomon Islands", false, false },
                    { 92, "ET", "Ethiopia", false, false },
                    { 93, "SO", "Somalia", false, false },
                    { 80, "PN", "Pitcairn", false, false },
                    { 251, "MZ", "Mozambique", false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 251);
        }
    }
}
