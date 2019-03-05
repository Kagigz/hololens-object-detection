using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


#region HelperClasses

// The objects contained in this script represent the deserialized version
// of the objects used by this application 

/// <summary>
/// Web request object for image data
/// </summary>
class MultipartObject : IMultipartFormSection
{
    public string sectionName { get; set; }

    public byte[] sectionData { get; set; }

    public string fileName { get; set; }

    public string contentType { get; set; }
}

/// <summary>
/// JSON of all Tags existing within the project
/// contains the list of Tags
/// </summary> 
public class Tags_RootObject
{
    public List<TagOfProject> Tags { get; set; }
    public int TotalTaggedImages { get; set; }
    public int TotalUntaggedImages { get; set; }
}

public class TagOfProject
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ImageCount { get; set; }
}

/// <summary>
/// JSON of Tag to associate to an image
/// Contains a list of hosting the tags,
/// since multiple tags can be associated with one image
/// </summary> 
public class Tag_RootObject
{
    public List<Tag> Tags { get; set; }
}

public class Tag
{
    public string ImageId { get; set; }
    public string TagId { get; set; }
}

/// <summary>
/// JSON of images submitted
/// Contains objects that host detailed information about one or more images
/// </summary> 
public class ImageRootObject
{
    public bool IsBatchSuccessful { get; set; }
    public List<SubmittedImage> Images { get; set; }
}

public class SubmittedImage
{
    public string SourceUrl { get; set; }
    public string Status { get; set; }
    public ImageObject Image { get; set; }
}

public class ImageObject
{
    public string Id { get; set; }
    public DateTime Created { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string ImageUri { get; set; }
    public string ThumbnailUri { get; set; }
}

/// <summary>
/// JSON of Service Iteration
/// </summary> 
public class Iteration
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool IsDefault { get; set; }
    public string Status { get; set; }
    public string Created { get; set; }
    public string LastModified { get; set; }
    public string TrainedAt { get; set; }
    public string ProjectId { get; set; }
    public bool Exportable { get; set; }
    public string DomainId { get; set; }
}

/// <summary>
/// Predictions received by the Service
/// after submitting an image for analysis
/// Includes Bounding Box
/// </summary>
public class AnalysisRootObject
{
    public string id { get; set; }
    public string project { get; set; }
    public string iteration { get; set; }
    public DateTime created { get; set; }
    public List<Prediction> predictions { get; set; }
}

public class BoundingBox
{
    public double left { get; set; }
    public double top { get; set; }
    public double width { get; set; }
    public double height { get; set; }
}

public class Prediction
{
    public double probability { get; set; }
    public string tagId { get; set; }
    public string tagName { get; set; }
    public BoundingBox boundingBox { get; set; }
}

#endregion

public class CustomVisionObjects : MonoBehaviour
{


}
