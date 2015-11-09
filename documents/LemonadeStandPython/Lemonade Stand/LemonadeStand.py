class LemonadeStand(object):
	def __init__(self):
		self.Account = UserAccounts()
		self.Customer = Customer()
		self.weather = Weather()
		
	def RunStand(self):
		self.weather.UpdateForecast()
		self.weather.UpdateTodaysWeather()