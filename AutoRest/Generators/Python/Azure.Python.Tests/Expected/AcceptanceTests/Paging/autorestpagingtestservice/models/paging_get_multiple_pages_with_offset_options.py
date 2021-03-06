# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class PagingGetMultiplePagesWithOffsetOptions(Model):
    """
    Additional parameters for the getMultiplePagesWithOffset operation.

    :param int maxresults: Sets the maximum number of items to return in the
     response.
    :param int offset: Offset of return value
    :param int timeout: Sets the maximum time that the server can spend
     processing the request, in seconds. The default is 30 seconds. Default
     value: 30 .
    """ 

    _validation = {
        'offset': {'required': True},
    }

    def __init__(self, offset, maxresults=None, timeout=30, **kwargs):
        self.maxresults = maxresults
        self.offset = offset
        self.timeout = timeout
