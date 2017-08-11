# Word Counter

#### C# Behavior Driven Development Project, 8/11/2017

#### By _Ben Budinger_

## Description

_This site will determine how frequently a word appears in a given string_
* The user will input a word and a string
* The number of times that word appears in the string will be returned
* Checking for full word matches

## Specs
1. An empty word or string will return -1
* input: ""
* return: -1
##### Base case test for that lazy user
2. A single matching word will return 1
* input: "Epicodus", "Learning at Epicodus is great!"
* return: 1
##### Making sure at least one match works
3. Multiple words are counted
* input: "code", "code all day, code all night, code code code"
* return: 5
##### Checking multiple matches excluding punctuation
4. Account for capitalization, only matching if caps match
* input: "aBBa", "aBBa AbbA"
* return: 1
##### Basic test for case sensitivity
5. Account for the word if the word in the sentence has punctuation attached to it - , . ! etc.
* input: "code", "I love to code, code, code!"
* return: 3
###### Testing to see if punctuation affects matching
6. Check if hyphenated words are matching
* input: "see-saw", "They played on the see-saw."
* return: 1
##### Tests to see if hyphenated words are still considered matching
7. If multiple words are searched for, only search for the first word delimited by a whitespace
* input: "see saw", "They played on the see see see saw"
* return: 3
##### Tests for when multiple words are searched for in error
8. Check string with numbers and special characters
* input: "l33tsp@ak", "I only speak l33tsp@ak!"
* return: 1;
##### Tests numbers and special characters for matching

## Setup

* This website will be hosted on GitHub
* https://github.com/budingerbc/RepeatCounter

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#
* Razor
* JQuery

### License

* Copyright (c) 2017 Ben Budinger
* This software is licensed under the MIT license.
