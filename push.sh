#!/bin/sh

setup_git() {
  git config --global user.email "travis@travis-ci.org"
  git config --global user.name "Travis CI"
}

commit_files() {
  git checkout -b master
  git add ./RomanNumbersTest/publish/
  git commit --message "Travis build: $TRAVIS_BUILD_NUMBER"
}

upload_files() {
  git remote add origin https://${GH_TOKEN}@github.com/TravisLearning/resources.git > /dev/null 2>&1
  git push origin HEAD:master
}

setup_git
commit_files
upload_files


