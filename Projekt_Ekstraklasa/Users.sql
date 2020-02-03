create table Users (
   Id		            numeric             identity,
   FirstName            varchar(30)			null,
   LastName				varchar(30)			 null,
   UserPassword			varchar(30)			 not null,
   EmailAddress         varchar(30)           not null,
)