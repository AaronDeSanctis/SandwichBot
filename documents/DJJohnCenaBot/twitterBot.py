import _random
from tweepy import *
from tweepy.auth import OAuthHandler
import tweepy,random,time
from tweepy import Stream
from keysOKitty import keysOKitty
from datetime import datetime,timedelta
from random import randint
import threading
from threading import Thread
from tweepy.streaming import StreamListener
import sys
import string
import datetime
now = datetime.datetime.now()
day=int(now.day)
month=int(now.month)
year=int(now.year)

class TwitterAPI(object):
   def __init__(self):
      consumer_key = keysOKitty['consumer_key']
      consumer_secret = keysOKitty['consumer_secret']
      auth = tweepy.OAuthHandler(consumer_key, consumer_secret)
      access_token = keysOKitty['access_token']
      access_token_secret = keysOKitty['access_token_secret']
      auth.set_access_token(access_token, access_token_secret)
      self.api = tweepy.API(auth)
      self.twitterQuotesList = open('kittyquotes.txt', 'r')
      self.tql = self.twitterQuotesList.readlines()
      self.twitterQuotesList.close()
      self.tweetQuery = ""
      self.tweetSearchResults = ""
      self.trends1 = ""
      self.hashtagsForTrends = ""
      self.hashtagsForKeywords = ""
      self.trend_hashtag = ""
      self.keyword_hashtag = ""
      self.keywords = ""
      self.specificKeywords = ""
      
   def searchTrends(self):
       self.trends1 = self.api.trends_place(2436704)
       self.hashtagsForTrends = [x['name'] for x in self.trends1[0]['trends'] if x['name'].startswith('#')]
       self.trend_hashtag = self.hashtagsForTrends[0]
       self.tweetSearchResults = self.api.search(q=self.trend_hashtag,count=100)
       
   # def searchKeyword(self):
       # self.keywords = self.api.["Video", "Game", "Games"]
       # self.hashtagsForKeywords = [x['name'] for x in self.keywords[0,len(self.keywords)]['trends'] if x['name'].startswith('#')]
       # self.keyword_hashtag = self.hashtagsForKeywords[0]
       # self.tweetQuery = self.api.search(q=self.keywords, count=5)
   
   def trendingTweet(self):
       for tweet in self.tweetSearchResults:
           sn = tweet.user.screen_name
           message = self.tql[randint(0,len(self.tql)-1)] 
           m = "@{0}, {1} {2}".format(sn, message,self.trend_hashtag) 
           s = self.api.update_status(status=m, in_reply_to_status_id = tweet.id)
           TimeToSleep = randint(1500,3000)
           time.sleep(TimeToSleep)

   # def keywordTweet(self):
       # for tweet1 in self.tweetQuery:
           # sn = tweet.user.screen_name
           # message = self.tql[randint(0,len(self.tql)-1)] 
           # m = "@{0}, {1} {2}".format(sn, message,self.trend_hashtag) 
           # s = self.api.update_status(status=m, in_reply_to_status_id = tweet.id)
           # TimeToSleep = randint(1500,3000)
           # time.sleep(TimeToSleep)
           
   def collectData(self):
       statuses = tweepy.Cursor(self.api.home_timeline).items(5)
       for status in statuses:
           outfp = open("TwitterData.txt", "w")
           outfp.write(status.text)
           outfp.close()
               
           
      
       
       
       #self.query = self.api.search.tweets(q = "Crazy lady")
       #for self.quote in self.twitterQuotesList:
       #self.api.update_status(status=self.quote)

if __name__ == "__main__":
  twitter = TwitterAPI()
  while True:
      twitter.collectData()
      twitter.searchTrends()
      twitter.trendingTweet()