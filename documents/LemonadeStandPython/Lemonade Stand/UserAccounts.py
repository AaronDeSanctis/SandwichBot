class UserAccounts(object):
	def __init__(self):
	self.currentAccountName = "" 
	self.currentPassword = ""
	self.newAccountName = ""
	self.newPassword = ""
	def MakeAccountName(self):
		self.currentAccountName = input('Enter Your UserName : ')
		self.currentPassword = input('Enter Your Password : ')
		
	def ChangeAccountName(self):
		self.newAccountName = input('Enter Your New UserName : ')
		self.currentAccountName = self.newAccountName
		self.newPassword = input('Enter Your New Password : ')
		self.currentPassword = self.newPassword
		
	def LogIn(self):
		if self.currentAccountName = input('Enter Your UserName : '):
		user.CheckAccountPassword()
		else:
			user.LogIn()
	def CheckAccountPassword(self)
		if self.currentPassword = input('Enter Your Password : '):
		#this is where the game would be started, to make sure their account and password are correct, and it would probably call the begin game function from the lemonade stand class
		else:
			user.CheckAccountName()
		
user = UserAccounts()	