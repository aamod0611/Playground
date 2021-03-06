from django.db import models
from django.core.urlresolvers import reverse


class Teams(models.Model):
    TeamName = models.CharField(max_length=20)
    TeamLead = models.CharField(max_length=20)
    ClientName = models.CharField(max_length=200)
    Tech = models.CharField(max_length=200)
    #Group = models.ForeignKey(CciGroup, blank=False, default=1)

    def get_absolute_url(self):
        return reverse('main:TeamDetails', kwargs={'pk': self.pk})

    def __str__(self):
        return self.TeamName

class TeamMembers(models.Model):
    Name = models.CharField(max_length = 200)
    DOB = models.DateField(max_length = 8)
    Designation = models.CharField(max_length = 200)
    Pic = models.FileField()
    Team = models.ForeignKey(Teams, blank=False, default=1)
    asd = models.CharField(max_length=200, default=1)

    def get_absolute_url(self):
        return reverse('main:details', kwargs={'pk': self.pk})

    def __str__(self):
        return self.Name


