import tweepy
from keys import keys 

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
    def tweet(self):
		for self.quote in self.twitterQuotesList:
			self.api.update_status(status=self.quote)

if __name__ == "__main__":
    twitter = TwitterAPI()
    twitter.tweet()