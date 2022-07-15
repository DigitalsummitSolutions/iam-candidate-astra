# Final Notes

---Data---


Since this was Green Field development, I decided to use Code-First database development in order to create the domain models rather than database first.  I also saw enough room for improvement that it made sense to redo everything.

In order to allow the application to function properly, you will need to create a LocalDB named IAMCandidateTest.
Migrations are created and run when starting up the application so there is no need to manually run those from Package Manager Console.
SeedData populates the database for lookups and test data.  This runs automatically every time the application starts up.



