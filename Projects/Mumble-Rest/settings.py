"""
settings.py

All default settings. No configuration required, unless you want to enable digest authentication.

:copyright: (C) 2014 by github.com/alfg.
:license:   MIT, see README for more details.
"""

import os

# Settings for running a local dev server with runserver.py
APP_HOST = os.environ.get("APP_HOST", "0.0.0.0")
APP_PORT = os.environ.get("APP_PORT", 8080)
APP_DEBUG = os.environ.get("APP_DEBUG") == "True"
APP_SECRET_KEY = os.environ.get("APP_SECRET_KEY", os.urandom(24))

# Ice connectivity
ICE_HOST_HOST = os.environ.get('MURMUR_ICE_HOST', 'localhost')
ICE_HOST_PORT = os.environ.get('MURMUR_ICE_PORT', '6502')
ICE_HOST = 'Meta:tcp -h ' + ICE_HOST_HOST + ' -p ' + ICE_HOST_PORT
ICE_SECRET = os.environ.get('ICE_SECRET', '')
ICE_MESSAGESIZE = 1024 # in KB - Ice default is 1024KB which is 1MB
SLICE_FILE = 'Murmur.ice'

# Default path of application
MURMUR_ROOT = os.path.dirname(os.path.abspath(__file__))

# Digest Authentication. Add users as necessary.
ENABLE_AUTH = os.environ.get("ENABLE_AUTH") == "True"

# If ENABLE_AUTH enabled, add user credentials below
users = os.environ.get("USERS", "")
USERS = dict(item.split(":") for item in users.split(",")) if users else dict()
