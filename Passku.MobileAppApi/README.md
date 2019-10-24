<center><img src="https://i.resimyukle.xyz/HRH0AR.png" width="%100" /></center>



# Passku Mobile App Api 
This Repository Includes Passku Mobile App Api Codes. <br/>



# What is Passku ? 
Passku is an open source password generation and password management platform. <br/>



## Api Docs
Here are the documents belonging to Api. <br/>
For all Endpoints, `apikey` should be defined under `Headers`. <br/>



### Users
**User Model:** username, password, nameSurname, mailAdress, createdDate. <br/>

Route| Http Verb | Post Body | Description
:--- | :---: | :---: | :---:
api/user | `GET` | Empty | List All Users
api/user/:id | `GET` | Empty | Get a User By Id
api/user| `POST` | User Model | Create a New User
api/user/:loginUsername/:loginPassword| `POST` | Empty | User Login System
api/user/:id | `PUT` | User Model | Update User
api/user/:id | `DELETE` | Empty | Delete User



### Passwords
**Password Model:** title, content, url, password, createdDate, user. <br/>

Route| Http Verb | Post Body | Description
:--- | :---: | :---: | :---:
api/password/:id | `GET` | Empty | List User's Password By Id
api/password/:user/:id | `GET` | Empty | Get a Password By Id
api/password/:id| `POST` | User Model | Create a New Password
api/password/:id | `PUT` | User Model | Update Password
api/password/:id | `DELETE` | Empty | Delete Password



### Contacts
**Contact Model:** firstName, lastName, email, subject, message, date. <br/>

Route| Http Verb | Post Body | Description
:--- | :---: | :---: | :---:
api/contact | `GET` | Empty | List All Contact Messages
api/contact | `POST` | Contact Model | Create a New Message
api/contact/:id | `PUT` | Contact Model | Update Contact
api/contact/:id | `DELETE` | Empty | Delete Contact



### Announcements
**Announcement Model:** title, description, date. <br/>

Route| Http Verb | Post Body | Description
:--- | :---: | :---: | :---:
api/announcement | `GET` | Empty | List All Announcements
api/announcement | `POST` | Announcement Model | Create a New Announcement
api/announcement/:id | `PUT` | Announcement Model | Update Announcement
api/announcement/:id | `DELETE` | Empty | Delete Announcement



### Reports
**Report Model:** title, content, date, user. <br/>

Route| Http Verb | Post Body | Description
:--- | :---: | :---: | :---:
api/report | `GET` | Empty | List All Reports
api/report/:user | `POST` | Report Model | Create a New Report
api/report/:id | `PUT` | Report Model | Update Report
api/report/:id | `DELETE` | Empty | Delete Report



### Managers
**Manager Model:** userName, password, apiKey. <br/>

Route| Http Verb | Post Body | Description
:--- | :---: | :---: | :---:
api/manager | `GET` | Empty | List All Managers
api/manager | `POST` | Manager Model | Create a New Manager
api/manager/:id | `PUT` | Manager Model | Update Manager
api/manager/:id | `DELETE` | Empty | Delete Manager



## Developers 
| Name        | Contact           |  Date  | Github Page | Web Site
| :------------- |:-------------:| :-----:| :-----:| :-----:|
| Berke Kurnaz | contact@berkekurnaz.com | 10/20/2019 | [Go To Page](https://github.com/berkekurnaz) | [Go To Page](http://www.berkekurnaz.com/)


## Lisence
We do not know the licenses. Also, we are totally open source fans .All codes in Passku are free of charge.

## Contact
contact@berkekurnaz.com