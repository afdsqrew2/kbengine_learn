# -*- coding: utf-8 -*-
import KBEngine
from KBEDebug import *

class FirstEntity(KBEngine.Entity):
	def __init__(self):
		self.client.onEnter()
		pass
	
	def say(self,id,content):
		INFO_MSG("Entity :%d Content %s"%(id,content))
		self.allClients.onSay("Entity :%d Content %s"%(id,content))
		pass
		
		