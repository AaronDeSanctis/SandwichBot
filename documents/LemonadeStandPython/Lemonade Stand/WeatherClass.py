from random import random
class Weather(object):
	def __init__(self):
		self.TempRange = [65,100]
		self.WeatherRange = [sunny, sunny, sunny, sunny, sunny, cloudy, cloudy, cloudy, rainy, rainy]
		self.nextWeather = none
		self.nextTemp = none
		self.currentWeather = none
		self.currentTemp = none
		
	def UpdateForecast(self)
		self.nextWeather = random.choice[self.WeatherRange]
		self.nextTemp = random.choice[self.TempRange]
		
	def UpdateTodaysWeather(self)
		if self.currentWeather == none 
			weather.UpdateForecast()
		else:	
			self.currentWeather = self.nextWeather
			self.currentTemp = self.nextTemp
		
weather = Weather()