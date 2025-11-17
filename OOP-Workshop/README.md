This is a private repository between:
Tobias,
Mikkel,
Vedran

Students at SDU conducting a workshop in OOP.

Mermaid UML diagram live editor link:
https://www.mermaidchart.com/app/projects/1d833c81-fdfb-403a-bfaa-77a4ad8a1839/diagrams/403decbf-f720-49f4-a532-160fbb4d25a8/share/invite/eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkb2N1bWVudElEIjoiNDAzZGVjYmYtZjcyMC00OWY0LWE1MzItMTYwZmJiNGQyNWE4IiwiYWNjZXNzIjoiRWRpdCIsImlhdCI6MTc2MzM4NDAyM30.f2rRiABVw4NS0CPf63n8jMo_lXRVngxTdh1z0_chm18


New Mermaid Test:
```mermaid
  classDiagram
direction TB
    class BaseUser {
	    + int x
	    + void xx()
    }

    class Borrower {
        
        + RateItem()
    }

    class Employee {
    }

    class Admin {
    }

    class BaseMedia {
	    - string title
	    + string GetTitle()
    }

    class E-Books {
	    + title string
	    + author string
	    + pages int
	    + publishYear int
	    + ISBN string
	    + language string
        + Download()
        + View()
    }

    class Movies {
	    + title string
	    + director string
	    + genres string
	    + releaseYear int
	    + language string
	    + duration int
        + Download()
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
        + Download()
        + PlaySong()
    }

    class Video-games {
	    + title string
	    + publisher string
	    + genre string
	    + releaseYear int
	    + supportedPlatforms string[]
        + isCompleted bool
        + Download()
        + PlayGame()
    }

    class Apps {
	    + title string
	    + publisher string
	    + version int
	    + language string
	    + supportedPlatforms string[]
        + Download()
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
        + Download()
        + PlayPodcast()
    }

    class Images {
	    + title string
        + resolution string
        + fileFormat string
        + fileSize long
        + dateTaken string
        + Download()
        + Display()
    }

    BaseUser <|-- Borrower
    BaseUser <|-- Employee
    BaseUser <|-- Admin
    BaseMedia <|-- E-Books
    BaseMedia <|-- Movies
    BaseMedia <|-- Songs
    BaseMedia <|-- Songs
    BaseMedia <|-- Video-games
    BaseMedia <|-- Apps
    BaseMedia <|-- Podcasts
    BaseMedia <|-- Images
```