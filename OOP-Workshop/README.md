This is a private repository between:
Tobias,
Mikkel,
Vedran

Students at SDU conducting a workshop in OOP.

CRC kort link:
https://drive.google.com/file/d/1dqogLdKY_-BCMUty8MtJ9YoWvOe8v2ko/view?usp=sharing

Mermaid UML diagram live editor link:
https://www.mermaidchart.com/app/projects/1d833c81-fdfb-403a-bfaa-77a4ad8a1839/diagrams/403decbf-f720-49f4-a532-160fbb4d25a8/share/invite/eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkb2N1bWVudElEIjoiNDAzZGVjYmYtZjcyMC00OWY0LWE1MzItMTYwZmJiNGQyNWE4IiwiYWNjZXNzIjoiRWRpdCIsImlhdCI6MTc2MzM4NDAyM30.f2rRiABVw4NS0CPf63n8jMo_lXRVngxTdh1z0_chm18


Noun/Verb analyse:
![UML](NounVerb.png)

CRC-kort:
![CRC](WorkshopCRC.png)

UML class diagram:
```mermaid
  classDiagram
direction TB
    class BaseUser {
        + name string
        + age int
        + securityNumber int

	    + void xx()
    }

    class Borrower {
        + ListMedia(BaseMedia type)
        + SelectMedia(BaseMedia media)
        + ViewMediaDetails(BaseMedia media)
        + RateMedia(BaseMedia media)
    }

    class MediaManager{
        <<interface>>
        + AddMedia(BaseMedia media)
        + RemoveMedia(BaseMedia media)
    }

    class Employee {
    }

    class Admin {
        + selectedUser 
        + ViewUsers(BaseUser userList)
        + CreateUser(string name, int age, int securityNumber)
        + SelectUser(BaseUser user)
        + UpdateUserName(string name)
        + UpdateUserAge(int age)
        + UpdateUserSecurityNumber(int securityNumber)
        + DeleteUser()
    }

    class BaseMedia {
	    + title string
	    + Download()
    }

    class E-Books {
	    + author string
	    + pages int
	    + publishYear int
	    + ISBN string
	    + language string
        + View()
    }

    class Movies {
	    + title string
	    + director string
	    + genres string
	    + releaseYear int
	    + language string
	    + duration int
        + Watch()
    }

    class Songs {
	    + title string
	    + composer string
	    + singer string
	    + genre string
	    + fileType string
	    + langauge string
	    + duration int
        + PlaySong()
    }

    class Video-games {
	    + title string
	    + publisher string
	    + genre string
	    + releaseYear int
	    + supportedPlatforms string[]
        + isCompleted bool
        + PlayGame()
    }

    class Apps {
	    + title string
	    + publisher string
	    + version int
	    + language string
	    + supportedPlatforms string[]
        + Execute()
    }

    class Podcasts {
        + title string
        + hosts string
        + guests string
        + episodeNumber int
        + releaseYear int
        + language string
        + episodeNumberIsComplete int
        + PlayPodcast()
    }

    class Images {
	    + title string
        + resolution string
        + fileFormat string
        + fileSize long
        + dateTaken string
        + Display()
    }

    BaseUser <|-- Borrower
    BaseUser <|-- Employee
    BaseUser <|-- Admin
    MediaManager <|.. Employee
    MediaManager <|.. Admin
    BaseMedia <|-- E-Books
    BaseMedia <|-- Movies
    BaseMedia <|-- Songs
    BaseMedia <|-- Songs
    BaseMedia <|-- Video-games
    BaseMedia <|-- Apps
    BaseMedia <|-- Podcasts
    BaseMedia <|-- Images


```
