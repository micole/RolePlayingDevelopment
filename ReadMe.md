# RolePlayingDevelopment #

Library to help generate locations and people for my tabletop games.

Currently the setting of the generated locations and people are in a generic fantasy setting. 

Hopefully I'll be able to create more settings as time goes on, but for now I just need to get the library in place.

## Character Development ##

A person can be described with the following:
- First Name
- Family Name
- Description
  - Created with PersonDescriptorFactory
- Job
  - Still working on how to describe jobs
- Race


### IPersonDescriptor/PersonDescriptorFactory ###

Any class that happens to implement the IPersonDescriptor can be called upon by the PersonDescriptorFactory to generate descriptions.

At the moment descriptions will always be [Description1] and [Description2].


## City Development ##

Cities are generated from Neighborhoods.

Neighborhoods are created from Buildings.

Buildings have a type as well as inhabitants (see person in character development).

