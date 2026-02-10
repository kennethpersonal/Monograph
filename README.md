# Kenneth Casin
# Monograph Test Examinatinon


## 🏗️ Project Structure

BlazorMonograph
├─ API	                                --> API Project
│  └─ Controller                        --> API Controller Folder
│     ├─ MonographController.cs         --> API Controller
│     └─ data.json                      --> Data source from separated files (60 records)
│                  
├─ SHARED                               --> SHARED Project. All objects shared/common across API and WEB
│  └─ Models                            --> Shared Models  
│                                                 
└─ WEB                    	        --> WEB Project. Client Side. All related with User Interface
   ├─ wwwwroot                          --> All Customized
   ├─ Components                        --> Components
   │  ├─ Pages                          --> Pages
   │  │   ├─ TabMenu                    --> Tab Menu. Details pages DetailHtmlData, Json and RawJson as required
   │  │   │  ├─ DetailHtmlData.razor    --> Display details in simple html
   │  │   │  ├─ Json.razor              --> Display details with customized UI
   │  │	  │  └─ RawJson.razor           --> Display data in raw json format
   │  │   └─ Home.razor                 --> Main page
   │  └─ Shared                         --> Reusable components like Button, Dropdown, Pagination and etc.
   └─ Services                          --> Consuming the API
 


### Instructon
NOTE! Make sure you have .NET 10 installed in your local


Cloning:
1. Use this link GitHub https://github.com/kennethpersonal/Monograph.git

Build:
1. Open the project
2. Select SHAARED project > Clean > Build
3. Select API project > Clean > Build
4. Select WEB project > Clean > Build

Run:
1. Press F5 or click Run button located at the top of visual studio.
