import _random
import tweepy
import tweepy,random,time
from keys import keys 
from datetime import datetime,timedelta
from random import randint

class TwitterAPI(object):
    def __init__(self):
        consumer_key = keys['consumer_key']
        consumer_secret = keys['consumer_secret']
        auth = tweepy.OAuthHandler(consumer_key, consumer_secret)
        access_token = keys['access_token']
        access_token_secret = keys['access_token_secret']
        auth.set_access_token(access_token, access_token_secret)
        self.api = tweepy.API(auth)
	self.twitterQuotesList = open('twitterquotes.txt', 'r')
	self.tql = self.twitterQuotesList.readlines()
	self.twitterQuotesList.close()
    def tweet(self):
		while True:
			trends1 = self.api.trends_place(2379574)
			hashtags = [x['name'] for x in trends1[0]['trends'] if x['name'].startswith('#')]
			trend_hashtag = hashtags[0]
			tweetSearchResults = self.api.search(q=trend_hashtag,count=50)  
			for tweet in tweetSearchResults:
				sn = tweet.user.screen_name
				message = self.tql[randint(0,len(self.tql)-1)] 
				m = "@{0}, {1} {2}".format(sn, message,trend_hashtag) 
				s = self.api.update_status(status=m, in_reply_to_status_id = tweet.id)
				TimeToSleep = randint(3600,4000)
				time.sleep(TimeToSleep)
		#for self.quote in self.twitterQuotesList:
			#self.api.update_status(status=self.quote)

if __name__ == "__main__":
    twitter = TwitterAPI()
    twitter.tweet()