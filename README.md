# GSFS Developer Evaluation

This repository is a submission to the GSFS Team for a Software Engineer position.

## Challenge 1 & Challenge 2

The submissions for challenges 1 and 2 can be found in the [ElectronicColorCode](ElectronicColorCode) directory.

## Challenge 3

The submission for challenge 3 can be found in the [SubItemSummaryReimplementation](SubItemSummaryReimplementation) directory.

## Challenge 4

The submission for challenge 4 can be found in the [BracketMatch](BracketMatch) directory.

## Challenge 5

The submission for challenge 5 is a small utility project I created to help with unit testing Swift/iOS apps. As pure Swift does not provide an easy way to create Mock objects for creating test-doubles, I decided to analyze my project source code and auto-generate Mock implementations for any protocols found. I called this utility "Mockr", and I created a couple of helper libraries to make it all work. The utility comprises the three repositories below:

- [bigfrancoag/ParseKit](https://github.com/bigfrancoag/ParseKit): A Swift library implementing the Parser Combinator Monad.

- [bigfrancoag/SwiftProtocolParser](https://github.com/bigfrancoag/SwiftProtocolParser): A Swift library using ParseKit to parse Swift source code files, find `protocol` definitions, and generate metadata defining those `protocols`.

- [bigfrancoag/Mockr](https://github.com/bigfrancoag/Mockr): A swift utility for auto-generating test-doubles (mocks) for a Swift project.

