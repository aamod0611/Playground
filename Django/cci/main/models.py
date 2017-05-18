from django.db import models
from django.core.urlresolvers import reverse


class TeamMembers(models.Model):
    Name = models.CharField(max_length = 200)
    DOB = models.DateField(max_length = 8)
    Designation = models.CharField(max_length = 200)
    Pic = models.FileField()

    def get_absolute_url(self):
        return reverse('main:details', kwargs={'pk': self.pk})

    def __str__(self):
        return self.Name
