from django.db import models
from django.core.urlresolvers import reverse

class Album(models.Model):
	artist = models.CharField(max_length = 200)
	title = models.CharField(max_length = 200)
	genre = models.CharField(max_length = 200)
	album_logo = models.FileField()
	# album_logo = models.CharField(max_length = 1000)
	
	def get_absolute_url(self):
		return reverse('music:detail', kwargs={'pk': self.pk})
	
	def __str__(self):
		return self.title
	
class song(models.Model):
	album = models.ForeignKey(Album, on_delete=models.CASCADE)
	file_type = models.CharField(max_length = 10)
	song_title = models.CharField(max_length = 250)
	
	def __str__(self):
		return self.song_title